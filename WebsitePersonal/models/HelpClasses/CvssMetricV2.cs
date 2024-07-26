using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public partial class CvssMetricV2
{
    [JsonProperty("source")]
    public CvssMetricV2Source Source { get; set; }

    [JsonProperty("type")]
    public TypeEnum Type { get; set; }

    [JsonProperty("cvssData")]
    public CvssData CvssData { get; set; }

    [JsonProperty("baseSeverity")]
    public Ity BaseSeverity { get; set; }

    [JsonProperty("exploitabilityScore")]
    public double ExploitabilityScore { get; set; }

    [JsonProperty("impactScore")]
    public double ImpactScore { get; set; }

    [JsonProperty("acInsufInfo")]
    public bool AcInsufInfo { get; set; }

    [JsonProperty("obtainAllPrivilege")]
    public bool ObtainAllPrivilege { get; set; }

    [JsonProperty("obtainUserPrivilege")]
    public bool ObtainUserPrivilege { get; set; }

    [JsonProperty("obtainOtherPrivilege")]
    public bool ObtainOtherPrivilege { get; set; }

    [JsonProperty("userInteractionRequired")]
    public bool UserInteractionRequired { get; set; }
}