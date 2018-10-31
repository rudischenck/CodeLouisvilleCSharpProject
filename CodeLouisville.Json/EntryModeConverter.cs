using System;
using Newtonsoft.Json;
using CodeLouisville.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisville.Json
{
    internal class EntryModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EntryMode) || t == typeof(EntryMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "INGEST")
            {
                return EntryMode.Ingest;
            }
            throw new Exception("Cannot unmarshal type EntryMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EntryMode)untypedValue;
            if (value == EntryMode.Ingest)
            {
                serializer.Serialize(writer, "INGEST");
                return;
            }
            throw new Exception("Cannot marshal type EntryMode");
        }

        public static readonly EntryModeConverter Singleton = new EntryModeConverter();
    }
}
