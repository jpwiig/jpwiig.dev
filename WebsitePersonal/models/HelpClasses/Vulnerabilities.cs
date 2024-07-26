using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Vulnerabilities
{
    [JsonProperty("cve")]
    public Cve Cve { get; set; }
}
