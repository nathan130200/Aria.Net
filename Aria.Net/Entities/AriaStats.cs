using Newtonsoft.Json;

namespace Aria.Net.Entities
{
	public class AriaStats
	{
		[JsonProperty("downloadSpeed", NullValueHandling = NullValueHandling.Ignore)]
		public string DownloadSpeed { get; internal set; }

		[JsonProperty("uploadSpeed", NullValueHandling = NullValueHandling.Ignore)]
		public string UploadSpeed { get; internal set; }

		[JsonProperty("numActive", NullValueHandling = NullValueHandling.Ignore)]
		public string ActiveDownloads { get; internal set; }

		[JsonProperty("numWaiting", NullValueHandling = NullValueHandling.Ignore)]
		public string WaitingDownloads { get; internal set; }

		[JsonProperty("numStopped", NullValueHandling = NullValueHandling.Ignore)]
		public string StoppedDownloads { get; internal set; }

		[JsonProperty("numStoppedTotal", NullValueHandling = NullValueHandling.Ignore)]
		public string TotalStoppedDownloads { get; internal set; }
	}
}
