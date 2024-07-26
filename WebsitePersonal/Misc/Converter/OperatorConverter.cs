using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class OperatorConverter : JsonConverter
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