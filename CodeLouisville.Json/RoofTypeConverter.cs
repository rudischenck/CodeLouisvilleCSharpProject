using System;
using Newtonsoft.Json;
using CodeLouisville.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Json
{
    internal class RoofTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RoofType) || t == typeof(RoofType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "dome":
                    return RoofType.Dome;
                case "outdoor":
                    return RoofType.Outdoor;
                case "retractable_dome":
                    return RoofType.RetractableDome;
            }
            throw new Exception("Cannot unmarshal type RoofType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RoofType)untypedValue;
            switch (value)
            {
                case RoofType.Dome:
                    serializer.Serialize(writer, "dome");
                    return;
                case RoofType.Outdoor:
                    serializer.Serialize(writer, "outdoor");
                    return;
                case RoofType.RetractableDome:
                    serializer.Serialize(writer, "retractable_dome");
                    return;
            }
            throw new Exception("Cannot marshal type RoofType");
        }

        public static readonly RoofTypeConverter Singleton = new RoofTypeConverter();
    }
}
