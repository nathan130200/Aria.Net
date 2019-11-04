using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aria.Net.Entities.Download
{
	public class AriaDownloadUri
	{
		[JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
		public Uri Uri { get; internal set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringEnumConverter))]
		public AriaDownloadUriStatus Status { get; internal set; }

		[JsonIgnore]
		public AriaDownloadFile File { get; internal set; }
	}
}
