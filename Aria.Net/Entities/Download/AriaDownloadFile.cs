using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aria.Net.Entities.Download
{
	public class AriaDownloadFile
	{
		[JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
		public int Index { get; internal set; }

		[JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; internal set; }

		[JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
		public long Length { get; internal set; }

		[JsonProperty("completedLength", NullValueHandling = NullValueHandling.Ignore)]
		public long CompletedLength { get; internal set; }

		[JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
		public bool IsSelected { get; internal set; }

		[JsonProperty("uris", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<AriaDownloadUri> Uris { get; internal set; }

		[JsonIgnore]
		public AriaDownload Download { get; internal set; }
	}
}
