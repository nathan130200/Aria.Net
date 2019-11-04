using Newtonsoft.Json;

namespace Aria.Net.Entities
{
	public class AriaErrorResponse
	{
		[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
		public int Code { get; internal set; }

		[JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; internal set; }
	}
}
