using System;
using Newtonsoft.Json;
using CodeLouisville.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Json
{
    internal class SurfaceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Surface) || t == typeof(Surface?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "artificial":
                    return Surface.Artificial;
                case "turf":
                    return Surface.Turf;
            }
            throw new Exception("Cannot unmarshal type Surface");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Surface)untypedValue;
            switch (value)
            {
                case Surface.Artificial:
                    serializer.Serialize(writer, "artificial");
                    return;
                case Surface.Turf:
                    serializer.Serialize(writer, "turf");
                    return;
            }
            throw new Exception("Cannot marshal type Surface");
        }

        public static readonly SurfaceConverter Singleton = new SurfaceConverter();
    }
}

