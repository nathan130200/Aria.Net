using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aria.Net.Entities.Download
{
	public class AriaVersion
	{
		[JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
		public string Version { get; internal set; }

		[JsonProperty("enabledFeatures", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<string> Features { get; internal set; }
	}
}
