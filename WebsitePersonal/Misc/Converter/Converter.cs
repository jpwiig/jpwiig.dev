using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BlazorApp1;

public class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            OperatorConverter.Singleton,
            LangConverter.Singleton,
            ItyConverter.Singleton,
            AccessVectorConverter.Singleton,
            AuthenticationConverter.Singleton,
            CvssMetricV2SourceConverter.Singleton,
            TypeEnumConverter.Singleton,
            SourceIdentifierEnumConverter.Singleton,
            TagConverter.Singleton,
            VulnStatusConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
    };
}