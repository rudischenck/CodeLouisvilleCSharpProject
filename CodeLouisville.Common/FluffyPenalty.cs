using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class FluffyPenalty
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("team")]
        public LocationClass Team { get; set; }
    }
}
