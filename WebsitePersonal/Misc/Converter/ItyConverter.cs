using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class ItyConverter : JsonConverter
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

    public static readonly ItyConverter Singelton = new ItyConverter(); 
}