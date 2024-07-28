using BlazorApp1.models.gen;
using Newtonsoft.Json;

namespace BlazorApp1.models.DTO;

public class CVEdto
{
    [JsonProperty("resultsPerPage")]
    public long ResultsPerPage { get; set; }

    [JsonProperty("startIndex")]
    public long StartIndex { get; set; }

    [JsonProperty("totalResults")]
    public long TotalResults { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    [JsonProperty("vulnerabilities")]
    public Vulnerabilities[] Vulnerabilities { get; set; }

}