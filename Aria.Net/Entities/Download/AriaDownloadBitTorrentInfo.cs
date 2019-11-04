using Newtonsoft.Json;

namespace Aria.Net.Entities.Download
{
	public class AriaDownloadBitTorrentInfo
	{
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; internal set; }

		[JsonIgnore]
		public AriaDownloadBitTorrent BitTorrent { get; internal set; }
	}
}
