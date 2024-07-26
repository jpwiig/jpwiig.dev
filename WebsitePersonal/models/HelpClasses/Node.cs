using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Node
{
    [JsonProperty("operator")]
    public Operator Operator { get; set; }
    
    [JsonProperty("negate")]
    public bool Negate { get; set; }
    
    [JsonProperty("cpeMatch")]
    public CpeMatch[] CpeMatch { get; set; }
}