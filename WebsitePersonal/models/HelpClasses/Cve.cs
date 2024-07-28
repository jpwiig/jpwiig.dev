using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Cve
{ 
[JsonProperty ("id")]
public string? Id { get; set; }
[JsonProperty ("sourceIdentifier")]
public string sourceIdentifier{ get; set;  }

[JsonProperty("published")] 
public DateTimeOffset LastModified { get; set; }

[JsonProperty ("vulnStatus")]
public VulnStatus vulnStatus { get; set;  }

[JsonProperty ("cveTags")]
public IEnumerable<Object> CveTags { get; set; }

[JsonProperty ("descriptions")]
public IEnumerable<Description> Descriptions { get; set; }

[JsonProperty ("metricts")]
public Metrics Metrics { get; set; }

[JsonProperty("weaknesses")]
public IEnumerable<Weakness> Weaknesses { get; set; }

[JsonProperty ("configuration")]
public IEnumerable<Configuration> Configurations { get; set; } //todo: change this

[JsonProperty("references")]
public IEnumerable<Reference> References { get; set; }

}