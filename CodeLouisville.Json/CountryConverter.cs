using System;
using Newtonsoft.Json;
using CodeLouisville.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Json
{
    internal class CountryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Country) || t == typeof(Country?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USA")
            {
                return Country.Usa;
            }
            throw new Exception("Cannot unmarshal type Country");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            if (value == Country.Usa)
            {
                serializer.Serialize(writer, "USA");
                return;
            }
            throw new Exception("Cannot marshal type Country");
        }

        public static readonly CountryConverter Singleton = new CountryConverter();
    }
}
