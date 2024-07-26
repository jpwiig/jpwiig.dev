using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class TypeEnumConverter : JsonConverter
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