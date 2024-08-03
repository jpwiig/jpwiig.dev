
namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JsonSchema
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
        public IEnumerable<Vulnerability> Vulnerabilities { get; set; }
    }

    public partial class Vulnerability
    {
        [JsonProperty("cve")]
        public Cve Cve { get; set; }
    }

    public partial class Cve
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sourceIdentifier")]
        public string SourceIdentifier { get; set; }

        [JsonProperty("published")]
        public DateTimeOffset Published { get; set; }

        [JsonProperty("lastModified")]
        public DateTimeOffset LastModified { get; set; }

        [JsonProperty("vulnStatus")]
        public string VulnStatus { get; set; }

        [JsonProperty("cveTags")]
        public IEnumerable<Object> CveTags { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<Description> Descriptions { get; set; }

        [JsonProperty("metrics")]
        public Metrics Metrics { get; set; }

        [JsonProperty("weaknesses")]
        public IEnumerable<Weakness> Weaknesses { get; set; }

        [JsonProperty("configurations")]
        public IEnumerable<Weakness> Configurations { get; set; }

        [JsonProperty("references")]
        public IEnumerable<Reference> References { get; set; }
    }

    public partial class Configuration
    {
        [JsonProperty("nodes")]
        public IEnumerable<Node> Nodes { get; set; }
    }

    public partial class Node
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("negate")]
        public bool Negate { get; set; }

        [JsonProperty("cpeMatch")]
        public IEnumerable<CpeMatch> CpeMatch { get; set; }
    }

    public partial class CpeMatch
    {
        [JsonProperty("vulnerable")]
        public bool Vulnerable { get; set; }

        [JsonProperty("criteria")]
        public string Criteria { get; set; }

        [JsonProperty("matchCriteriaId")]
        public string MatchCriteriaId { get; set; }

        [JsonProperty("versionEndIncluding", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionEndIncluding { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Metrics
    {
        [JsonProperty("cvssMetricV2")]
        public IEnumerable<CvssMetricV2> CvssMetricV2 { get; set; }
    }

    public partial class CvssMetricV2
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cvssData")]
        public CvssData CvssData { get; set; }

        [JsonProperty("baseSeverity")]
        public string BaseSeverity { get; set; }

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

    public partial class CvssData
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vectorString")]
        public string VectorString { get; set; }

        [JsonProperty("accessVector")]
        public string AccessVector { get; set; }

        [JsonProperty("accessComplexity")]
        public string AccessComplexity { get; set; }

        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonProperty("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonProperty("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonProperty("baseScore")]
        public double BaseScore { get; set; }
    }

    public partial class Reference
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }
    }

    public partial class Weakness
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public IEnumerable<Description> Description { get; set; }
    }

    public enum Operator { Or };

    public enum Lang { En, Es };

    public enum Ity { High, Low, Medium };

    public enum AccessVector { Local, Network };

    public enum Authentication { Complete, None, Partial };

    public enum CvssMetricV2Source { NvdNistGov };

    public enum TypeEnum { Primary };

    public enum SourceIdentifierEnum { CveMitreOrg };

    public enum Tag { Patch, ThirdPartyAdvisory, UsGovernmentResource, VendorAdvisory };

    public enum VulnStatus { Analyzed, Modified };

    public partial class JsonSchema
    {
        public static JsonSchema FromJson(string json) => JsonConvert.DeserializeObject<JsonSchema>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this JsonSchema self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                OperatorConverter.Singleton,
                LangConverter.Singleton,
                ItyConverter.Singleton,
                AccessVectorConverter.Singleton,
                AuthenticationConverter.Singleton,
                CvssMetricV2SourceConverter.Singleton,
                TypeEnumConverter.Singleton,
                SourceIdentifierEnumConverter.Singleton,
                TagConverter.Singleton,
                VulnStatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class OperatorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Operator) || t == typeof(Operator?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "OR")
            {
                return Operator.Or;
            }
            throw new Exception("Cannot unmarshal type Operator");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Operator)untypedValue;
            if (value == Operator.Or)
            {
                serializer.Serialize(writer, "OR");
                return;
            }
            throw new Exception("Cannot marshal type Operator");
        }

        public static readonly OperatorConverter Singleton = new OperatorConverter();
    }

    internal class LangConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lang) || t == typeof(Lang?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "en":
                    return Lang.En;
                case "es":
                    return Lang.Es;
            }
            throw new Exception("Cannot unmarshal type Lang");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Lang)untypedValue;
            switch (value)
            {
                case Lang.En:
                    serializer.Serialize(writer, "en");
                    return;
                case Lang.Es:
                    serializer.Serialize(writer, "es");
                    return;
            }
            throw new Exception("Cannot marshal type Lang");
        }

        public static readonly LangConverter Singleton = new LangConverter();
    }

    internal class ItyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ity) || t == typeof(Ity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "HIGH":
                    return Ity.High;
                case "LOW":
                    return Ity.Low;
                case "MEDIUM":
                    return Ity.Medium;
            }
            throw new Exception("Cannot unmarshal type Ity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ity)untypedValue;
            switch (value)
            {
                case Ity.High:
                    serializer.Serialize(writer, "HIGH");
                    return;
                case Ity.Low:
                    serializer.Serialize(writer, "LOW");
                    return;
                case Ity.Medium:
                    serializer.Serialize(writer, "MEDIUM");
                    return;
            }
            throw new Exception("Cannot marshal type Ity");
        }

        public static readonly ItyConverter Singleton = new ItyConverter();
    }

    internal class AccessVectorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccessVector) || t == typeof(AccessVector?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "LOCAL":
                    return AccessVector.Local;
                case "NETWORK":
                    return AccessVector.Network;
            }
            throw new Exception("Cannot unmarshal type AccessVector");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccessVector)untypedValue;
            switch (value)
            {
                case AccessVector.Local:
                    serializer.Serialize(writer, "LOCAL");
                    return;
                case AccessVector.Network:
                    serializer.Serialize(writer, "NETWORK");
                    return;
            }
            throw new Exception("Cannot marshal type AccessVector");
        }

        public static readonly AccessVectorConverter Singleton = new AccessVectorConverter();
    }

    internal class AuthenticationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Authentication) || t == typeof(Authentication?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMPLETE":
                    return Authentication.Complete;
                case "NONE":
                    return Authentication.None;
                case "PARTIAL":
                    return Authentication.Partial;
            }
            throw new Exception("Cannot unmarshal type Authentication");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Authentication)untypedValue;
            switch (value)
            {
                case Authentication.Complete:
                    serializer.Serialize(writer, "COMPLETE");
                    return;
                case Authentication.None:
                    serializer.Serialize(writer, "NONE");
                    return;
                case Authentication.Partial:
                    serializer.Serialize(writer, "PARTIAL");
                    return;
            }
            throw new Exception("Cannot marshal type Authentication");
        }

        public static readonly AuthenticationConverter Singleton = new AuthenticationConverter();
    }

    internal class CvssMetricV2SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CvssMetricV2Source) || t == typeof(CvssMetricV2Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "nvd@nist.gov")
            {
                return CvssMetricV2Source.NvdNistGov;
            }
            throw new Exception("Cannot unmarshal type CvssMetricV2Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CvssMetricV2Source)untypedValue;
            if (value == CvssMetricV2Source.NvdNistGov)
            {
                serializer.Serialize(writer, "nvd@nist.gov");
                return;
            }
            throw new Exception("Cannot marshal type CvssMetricV2Source");
        }

        public static readonly CvssMetricV2SourceConverter Singleton = new CvssMetricV2SourceConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Primary")
            {
                return TypeEnum.Primary;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Primary)
            {
                serializer.Serialize(writer, "Primary");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class SourceIdentifierEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SourceIdentifierEnum) || t == typeof(SourceIdentifierEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "cve@mitre.org")
            {
                return SourceIdentifierEnum.CveMitreOrg;
            }
            throw new Exception("Cannot unmarshal type SourceIdentifierEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SourceIdentifierEnum)untypedValue;
            if (value == SourceIdentifierEnum.CveMitreOrg)
            {
                serializer.Serialize(writer, "cve@mitre.org");
                return;
            }
            throw new Exception("Cannot marshal type SourceIdentifierEnum");
        }

        public static readonly SourceIdentifierEnumConverter Singleton = new SourceIdentifierEnumConverter();
    }

    internal class TagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tag) || t == typeof(Tag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Patch":
                    return Tag.Patch;
                case "Third Party Advisory":
                    return Tag.ThirdPartyAdvisory;
                case "US Government Resource":
                    return Tag.UsGovernmentResource;
                case "Vendor Advisory":
                    return Tag.VendorAdvisory;
            }
            throw new Exception("Cannot unmarshal type Tag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tag)untypedValue;
            switch (value)
            {
                case Tag.Patch:
                    serializer.Serialize(writer, "Patch");
                    return;
                case Tag.ThirdPartyAdvisory:
                    serializer.Serialize(writer, "Third Party Advisory");
                    return;
                case Tag.UsGovernmentResource:
                    serializer.Serialize(writer, "US Government Resource");
                    return;
                case Tag.VendorAdvisory:
                    serializer.Serialize(writer, "Vendor Advisory");
                    return;
            }
            throw new Exception("Cannot marshal type Tag");
        }

        public static readonly TagConverter Singleton = new TagConverter();
    }

    internal class VulnStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VulnStatus) || t == typeof(VulnStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Analyzed":
                    return VulnStatus.Analyzed;
                case "Modified":
                    return VulnStatus.Modified;
            }
            throw new Exception("Cannot unmarshal type VulnStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VulnStatus)untypedValue;
            switch (value)
            {
                case VulnStatus.Analyzed:
                    serializer.Serialize(writer, "Analyzed");
                    return;
                case VulnStatus.Modified:
                    serializer.Serialize(writer, "Modified");
                    return;
            }
            throw new Exception("Cannot marshal type VulnStatus");
        }

        public static readonly VulnStatusConverter Singleton = new VulnStatusConverter();
    }
}
