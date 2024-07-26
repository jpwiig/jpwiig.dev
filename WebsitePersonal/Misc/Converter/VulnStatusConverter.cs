using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class VulnStatusConverter : JsonConverter
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