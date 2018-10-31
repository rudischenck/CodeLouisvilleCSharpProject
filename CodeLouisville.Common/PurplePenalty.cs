using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class PurplePenalty
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("no_play", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoPlay { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? Yards { get; set; }

        [JsonProperty("team")]
        public LocationClass Team { get; set; }
    }
}
