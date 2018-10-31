using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class LastEvent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }
    }
}
