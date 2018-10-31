using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Broadcast
    {
        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("satellite", NullValueHandling = NullValueHandling.Ignore)]
        public long? Satellite { get; set; }

        [JsonProperty("internet", NullValueHandling = NullValueHandling.Ignore)]
        public string Internet { get; set; }
    }
}
