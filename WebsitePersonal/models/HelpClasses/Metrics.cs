using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class Metrics
{
    [JsonProperty("cvssMetricV2")]
    public CvssMetricV2[] CvssMetricV2 { get; set; }
}