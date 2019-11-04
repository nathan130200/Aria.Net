using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aria.Net.Entities
{
	public class AriaResponse
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; internal set; }

        [JsonProperty("jsonrpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; internal set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public AriaErrorResponse Error { get; internal set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Result { get; internal set; }
    }
}
