using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class PlayDetail
    {
        [JsonProperty("category")]
        public DetailCategory Category { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("start_location")]
        public Location StartLocation { get; set; }

        [JsonProperty("end_location")]
        public Location EndLocation { get; set; }

        [JsonProperty("players")]
        public Player[] Players { get; set; }

        [JsonProperty("yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? Yards { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public Result? Result { get; set; }

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [JsonProperty("penalty", NullValueHandling = NullValueHandling.Ignore)]
        public PurplePenalty Penalty { get; set; }

        [JsonProperty("review", NullValueHandling = NullValueHandling.Ignore)]
        public Review Review { get; set; }
    }
}
