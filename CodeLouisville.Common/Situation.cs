using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Situation
    {
        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("down")]
        public long Down { get; set; }

        [JsonProperty("yfd")]
        public long Yfd { get; set; }

        [JsonProperty("possession")]
        public LocationClass Possession { get; set; }

        [JsonProperty("location")]
        public LocationClass Location { get; set; }
    }
}
