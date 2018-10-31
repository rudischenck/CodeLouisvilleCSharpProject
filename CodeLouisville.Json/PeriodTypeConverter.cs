using System;
using Newtonsoft.Json;
using CodeLouisville.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Json
{
    internal class PeriodTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PeriodType) || t == typeof(PeriodType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "overtime":
                    return PeriodType.Overtime;
                case "quarter":
                    return PeriodType.Quarter;
            }
            throw new Exception("Cannot unmarshal type PeriodType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PeriodType)untypedValue;
            switch (value)
            {
                case PeriodType.Overtime:
                    serializer.Serialize(writer, "overtime");
                    return;
                case PeriodType.Quarter:
                    serializer.Serialize(writer, "quarter");
                    return;
            }
            throw new Exception("Cannot marshal type PeriodType");
        }

        public static readonly PeriodTypeConverter Singleton = new PeriodTypeConverter();
    }
}
