using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1.models.gen;

public class Cve
{ 
[JsonProperty ("id")]
public string? Id { get; set; }
[JsonProperty ("sourceIdentifier")]
public SourceIdentifierEnum SourceIdentifier { get; set;  }

[JsonProperty("published")] 
public DateTimeOffset LastModified { get; set; }

[JsonProperty ("vulnStatus")]
public VulnStatus vulnStatus { get; set;  }

[JsonProperty ("cveTags")]
public object[] CveTags { get; set; }

[JsonProperty ("descriptions")]
public Description[] Descriptions { get; set; }

[JsonProperty ("metricts")]
public Metrics Metrics { get; set; }

[JsonProperty ("configuration")]
public Configuration[] Configurations { get; set; } //todo: change this

[JsonProperty("reference")]
public Reference[] References { get; set; }

}