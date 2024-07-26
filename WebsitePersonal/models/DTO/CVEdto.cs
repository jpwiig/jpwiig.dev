using BlazorApp1.models.gen;
using Newtonsoft.Json;

namespace BlazorApp1.models.DTO;

public class CVEdto
{
    [JsonProperty ("resultsPerPage")]
    private long resultPerpage { get; set; }
    [JsonProperty ("startIndex")]
    private long startIndex { get; set; }
    [JsonProperty ("totalResults")] 
    private long totalResults { get; set; }
   [JsonProperty ("format")]
    private string format { get; set; }
    [JsonProperty ("timestamp")]
    private DateTimeOffset timestamp { get; set; } //date
    [JsonProperty ("vulnerabilities")]
    private List<Vulnerabilities> Vulnarbilities { get; set; }
}