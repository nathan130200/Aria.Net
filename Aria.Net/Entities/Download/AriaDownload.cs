using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Aria.Net.Entities.Download
{
	public class AriaDownload
	{
		[JsonIgnore]
		public AriaClient Client { get; internal set; }

		[JsonProperty("gid", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; internal set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
		public AriaDownloadStatus Status { get; internal set; }

		[JsonProperty("totalLength", NullValueHandling = NullValueHandling.Ignore)]
		public long TotalLength { get; internal set; }

		[JsonProperty("completedLength", NullValueHandling = NullValueHandling.Ignore)]
		public long CompletedLength { get; internal set; }

		[JsonProperty("uploadLength", NullValueHandling = NullValueHandling.Ignore)]
		public long UploadLength { get; internal set; }

		[JsonProperty("bitfield", NullValueHandling = NullValueHandling.Ignore)]
		public string BitField { get; internal set; }

		[JsonProperty("downloadSpeed", NullValueHandling = NullValueHandling.Ignore)]
		public int DownloadSpeed { get; internal set; }

		[JsonProperty("uploadSpeed", NullValueHandling = NullValueHandling.Ignore)]
		public int UploadSpeed { get; internal set; }

		[JsonProperty("infoHash", NullValueHandling = NullValueHandling.Ignore)]
		public string Hash { get; internal set; }

		[JsonProperty("numSeeders", NullValueHandling = NullValueHandling.Ignore)]
		public int NumSeeders { get; internal set; }

		[JsonProperty("seeder", NullValueHandling = NullValueHandling.Ignore)]
		public bool Seeder { get; internal set; }

		[JsonProperty("pieceLength", NullValueHandling = NullValueHandling.Ignore)]
		public long PieceLength { get; internal set; }

		[JsonProperty("numPieces", NullValueHandling = NullValueHandling.Ignore)]
		public int NumPieces { get; internal set; }

		[JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
		public int Connections { get; internal set; }

		[JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
		public int ErrorCode { get; internal set; }

		[JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorMessage { get; internal set; }

		[JsonProperty("followedBy", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<string> FollowedBy { get; internal set; }

		[JsonProperty("following", NullValueHandling = NullValueHandling.Ignore)]
		public bool Following { get; internal set; }

		[JsonProperty("belongsTo", NullValueHandling = NullValueHandling.Ignore)]
		public string BelongsTo { get; internal set; }

		[JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
		public string Directory { get; internal set; }

		[JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<AriaDownloadFile> Files { get; internal set; }

		[JsonProperty("bittorrent", NullValueHandling = NullValueHandling.Ignore)]
		public AriaDownloadBitTorrent BitTorrent { get; internal set; }

		[JsonProperty("verifiedLength", NullValueHandling = NullValueHandling.Ignore)]
		public long VerifiedLength { get; internal set; }

		[JsonProperty("verifyIntegrityPending", NullValueHandling = NullValueHandling.Ignore)]
		public bool VerifyIntegrityPending { get; internal set; }

		public async Task PauseAsync(bool force)
		{
			var res = await this.Client.SendAsync($"aria2.{(force ? "forcePause" : "pause")}", new JArray(this.Id));

			if (res.Error != null)
				throw new Exception($"({res.Error.Code}) {res.Error.Message}");
		}

		public async Task ResumeAsync()
		{
			var res = await this.Client.SendAsync("aria2.unpause", new JArray(this.Id));

			if (res.Error != null)
				throw new Exception($"({res.Error.Code}) {res.Error.Message}");
		}

		public async Task RemoveAsync(bool force = false)
		{
			var res = await this.Client.SendAsync($"aria2.{(force ? "forceRemove" : "remove")}", new JArray(this.Id));

			if (res.Error != null)
				throw new Exception($"({res.Error.Code}) {res.Error.Message}");
		}
	}
}
