using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class CvssData
{
    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("vectorString")]
    public string VectorString { get; set; }

    [JsonProperty("accessVector")]
    public AccessVector AccessVector { get; set; }

    [JsonProperty("accessComplexity")]
    public Ity AccessComplexity { get; set; }

    [JsonProperty("authentication")]
    public Authentication Authentication { get; set; }

    [JsonProperty("confidentialityImpact")]
    public Authentication ConfidentialityImpact { get; set; }

    [JsonProperty("integrityImpact")]
    public Authentication IntegrityImpact { get; set; }

    [JsonProperty("availabilityImpact")]
    public Authentication AvailabilityImpact { get; set; }

    [JsonProperty("baseScore")]
    public double BaseScore { get; set; }
}