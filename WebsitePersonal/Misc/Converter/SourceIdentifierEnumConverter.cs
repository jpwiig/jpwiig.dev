using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class SourceIdentifierEnumConverter : JsonConverter
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