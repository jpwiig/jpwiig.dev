using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class AuthenticationConverter : JsonConverter
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
