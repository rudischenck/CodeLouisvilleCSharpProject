using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Summary
    {
        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("week")]
        public Week Week { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("home")]
        public Away Home { get; set; }

        [JsonProperty("away")]
        public Away Away { get; set; }
    }
}
