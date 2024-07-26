using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class CpeMatch
{
[JsonProperty("vulnerable")]
public bool Vulnerable { get; set; }

[JsonProperty("matchCriteriaId")]
public string MatchCriteriaId { get; set; }

[JsonProperty("versionEndIncluding", NullValueHandling = NullValueHandling.Ignore)]
public string VersionEndIncluding { get; set; }
}