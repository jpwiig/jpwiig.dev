using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class AccessVectorConverter : JsonConverter
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
    