using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class TagConverter : JsonConverter
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