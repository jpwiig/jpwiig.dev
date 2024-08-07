using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class LangConverter : JsonConverter
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