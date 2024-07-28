using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class Reference
{
    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public Tag[] Tags { get; set; }
}
