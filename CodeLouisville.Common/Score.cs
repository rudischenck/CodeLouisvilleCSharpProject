using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Score
    {
        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("home_points")]
        public long HomePoints { get; set; }

        [JsonProperty("away_points")]
        public long AwayPoints { get; set; }

        [JsonProperty("points-after-play", NullValueHandling = NullValueHandling.Ignore)]
        public PointsAfterPlay PointsAfterPlay { get; set; }
    }
}
