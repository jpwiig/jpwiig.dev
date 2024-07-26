using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class Weakness
{
    [JsonProperty("source")]
    public CvssMetricV2Source Source { get; set; }

    [JsonProperty("type")]
    public TypeEnum Type { get; set; }

    [JsonProperty("description")]
    public Description[] Description { get; set; }
}
