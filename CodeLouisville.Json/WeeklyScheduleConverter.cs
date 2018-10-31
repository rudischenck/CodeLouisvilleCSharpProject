using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace CodeLouisville.Json
{
    internal static class WeeklyScheduleConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                EntryModeConverter.Singleton,
                PeriodTypeConverter.Singleton,
                StatusConverter.Singleton,
                CountryConverter.Singleton,
                RoofTypeConverter.Singleton,
                SurfaceConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
