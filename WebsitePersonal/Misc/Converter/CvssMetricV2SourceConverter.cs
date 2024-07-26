using BlazorApp1.models.gen.Enum;
using Newtonsoft.Json;

namespace BlazorApp1;

public class CvssMetricV2SourceConverter : JsonConverter
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