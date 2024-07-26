using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class Description
{
    [JsonProperty("lang")]
    public Lang Lang { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}