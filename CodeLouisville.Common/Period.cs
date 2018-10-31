using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Period
    {
        [JsonProperty("period_type")]
        public PeriodType PeriodType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("home_points")]
        public long HomePoints { get; set; }

        [JsonProperty("away_points")]
        public long AwayPoints { get; set; }
    }
}
