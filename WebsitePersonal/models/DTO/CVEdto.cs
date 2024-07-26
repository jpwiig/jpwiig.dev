using BlazorApp1.models.gen;
using Newtonsoft.Json;

namespace BlazorApp1.models.DTO;

public class CVEdto
{
    [JsonProperty ("resultsPerPage")]
    public long resultPerpage { get; set; }
    [JsonProperty ("startIndex")]
    public long startIndex { get; set; }
    [JsonProperty ("totalResults")] 
    public long totalResults { get; set; } 
    [JsonProperty ("format")]
    public string format { get; set; }
    [JsonProperty ("timestamp")]
    public DateTimeOffset timestamp { get; set; } //date
    [JsonProperty ("vulnerabilities")]
    public Vulnerabilities[] Vulnarbilities { get; set; }
}