using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Configuration
{
 [JsonProperty ("nodes")]
 public Node[] Nodes { get; set; }
}