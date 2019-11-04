using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aria.Net.Entities.Download
{
    public class AriaDownloadBitTorrent
    {
        [JsonProperty("announceList", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IEnumerable<string>> Announces { get; internal set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; internal set; }

        [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public long CreationTimestamp { get; internal set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
        public AriaBitTorrentMode Mode { get; internal set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public AriaDownloadBitTorrentInfo Info { get; internal set; }

        [JsonIgnore]
        public AriaDownload Download { get; internal set; }
    }
}
