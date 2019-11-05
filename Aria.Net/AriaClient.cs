using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Aria.Net.Entities;
using Aria.Net.Entities.Download;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace Aria.Net
{
	public class AriaClient
	{
		public AriaConfiguration Configuration
		{
			get;
			internal set;
		}

		internal string _endpoint;
		internal WebSocket _websocket;
		internal ConcurrentDictionary<string, Action<AriaResponse>> _callbacks;

		public AriaClient(AriaConfiguration configuration)
		{
			this.Configuration = configuration;

			if (string.IsNullOrEmpty(this.Configuration.Host))
				throw new ArgumentNullException(nameof(this.Configuration.Host), "Host cannot be null or empty.");

			if (this.Configuration.Port <= 0 || this.Configuration.Port >= ushort.MaxValue)
				throw new ArgumentOutOfRangeException(nameof(this.Configuration.Port), "Port must be in valid range (1-65535).");

			var prefix = "ws";

			if (this.Configuration.IsSecure)
				prefix = "wss";

			if (this.Configuration.UseAuthentication)
			{
				if (string.IsNullOrEmpty(this.Configuration.Token))
					this.Configuration.UseAuthentication = false;
			}

			this._endpoint = $"{prefix}://{this.Configuration.Host}:{this.Configuration.Port}/jsonrpc";
			this._callbacks = new ConcurrentDictionary<string, Action<AriaResponse>>();
			this._websocket = new WebSocket(this._endpoint);
			this._websocket.OnMessage += this.WS_OnMessage;
		}

		void WS_OnMessage(object sender, MessageEventArgs e)
		{
			if (!e.IsText)
				return;

			var raw = JObject.Parse(e.Data);
			var response = raw.ToObject<AriaResponse>();

			Debug.WriteLine("Aria2/Recv <<:\n{0}\n", args: raw.ToString(Formatting.Indented));

			if (!string.IsNullOrEmpty(response.Id))
			{
				if (this._callbacks.TryRemove(response.Id, out var callback))
					callback(response);
			}
		}

		public Task ConnectAsync()
		{
			this._websocket.Connect();
			return Task.CompletedTask;
		}

		public Task DisconnectAsync()
		{
			this._websocket.Close(CloseStatusCode.Normal);
			return Task.CompletedTask;
		}

		internal Task<AriaResponse> SendAsync(string method, JArray arguments = default)
		{
			var tsc = new TaskCompletionSource<AriaResponse>();
			var id = Guid.NewGuid().ToString("D");

			if (arguments == null)
				arguments = new JArray();

			if (this.Configuration.UseAuthentication && !string.IsNullOrEmpty(this.Configuration.Token))
				arguments.AddFirst(new JArray($"token:{this.Configuration.Token}")); // [secret], ...params

			var payload = new JObject();
			payload["id"] = id;
			payload["method"] = method;
			payload["jsonrpc"] = "2.0";
			payload["params"] = arguments;

			var callback = new Action<AriaResponse>(result =>
			{
				if (result.Error != null)
				{
					var ex = new AriaException(result.Error.Code, result.Error.Message);
					Debug.WriteLine(ex.ToString() + "\n");
					tsc.TrySetException(ex);
				}
				else
					tsc.TrySetResult(result);
			});

			this._callbacks.AddOrUpdate(id, callback, (key, old) => callback);
			this._websocket.SendAsync(payload.ToString(Formatting.None), completed =>
			{
				if (!completed)
					tsc.TrySetException(new Exception("Cannot send payload to Aria2 RPC"));

				Debug.WriteLine("Aria2/Send >>:\n{0}\n", args: payload.ToString(Formatting.Indented));
			});

			return tsc.Task;
		}

		internal async Task<IEnumerable<AriaDownload>> GetDownloadsAsync(string method, JArray arguments)
		{
			var res = await this.SendAsync(method, arguments);

			var downloads = res.Result
				.ToObject<IEnumerable<AriaDownload>>();

			foreach (var download in downloads)
			{
				download.Client = this;

				if (download.BitTorrent != null)
					download.BitTorrent.Download = download;

				if (download.Files != null)
				{
					foreach (var file in download.Files)
					{
						if (file != null)
						{
							file.Download = download;

							if (file.Uris != null)
								foreach (var uri in file.Uris)
									uri.File = file;
						}
					}
				}
			}

			return downloads;
		}

		public async Task<AriaDownload> GetDownloadAsync(string id, params string[] fields)
		{
			if (string.IsNullOrEmpty(id))
				throw new ArgumentNullException(nameof(id), "Download GID cannot be null or empty.");

			JArray arguments;

			if (fields == null || fields.Length == 0)
				arguments = new JArray(id);
			else
				arguments = new JArray(id, new JArray(fields));

			var res = await this.SendAsync("aria2.tellStatus", arguments);
			var download = res.Result.ToObject<AriaDownload>();

			download.Client = this;

			if (download.BitTorrent != null)
				download.BitTorrent.Download = download;

			if (download.Files != null)
			{
				foreach (var file in download.Files)
				{
					if (file != null)
					{
						file.Download = download;

						if (file.Uris != null)
							foreach (var uri in file.Uris)
								uri.File = file;
					}
				}
			}

			return download;
		}

		public Task<IEnumerable<AriaDownload>> GetActiveDownloadsAsync(params string[] fields)
		{
			JArray arguments;

			if (fields == null || fields.Length == 0)
				arguments = default;
			else
				arguments = new JArray(new JArray(fields));

			return this.GetDownloadsAsync("aria2.tellActive", arguments);
		}

		public Task<IEnumerable<AriaDownload>> GetWaitingDownloadsAsync(int index = -1, int limit = 5, params string[] fields)
		{
			JArray arguments;

			if (fields == null || fields.Length == 0)
				arguments = new JArray(index, limit);
			else
				arguments = new JArray(index, limit, new JArray(fields));

			return this.GetDownloadsAsync("aria2.tellWaiting", arguments);
		}

		public Task<IEnumerable<AriaDownload>> GetStoppedDownloadsAsync(int index = -1, int limit = 5, params string[] fields)
		{
			JArray arguments;

			if (fields == null || fields.Length == 0)
				arguments = new JArray(index, limit);
			else
				arguments = new JArray(index, limit, new JArray(fields));

			return this.GetDownloadsAsync("aria2.tellStopped", arguments);
		}

		public async Task<AriaStats> GetStatsAsync()
		{
			var res = await this.SendAsync("aria2.getGlobalStat");
			return res.Result.ToObject<AriaStats>();
		}

		public async Task<AriaVersion> GetVersionAsync()
		{
			var res = await this.SendAsync("aria2.getVersion");
			return res.Result.ToObject<AriaVersion>();
		}
	}
}