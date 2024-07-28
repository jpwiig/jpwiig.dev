using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Weakness
{
    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("type")]
    public TypeEnum Type { get; set; }

    [JsonProperty("description")]
    public IEnumerable<Description> Description { get; set; }
}
