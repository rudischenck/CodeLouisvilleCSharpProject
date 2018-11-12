//scoring data structure, contains the scores data the user requests.

using Newtonsoft.Json;
using System;

namespace CodeLouisville.Common
{
    public partial class Scoring
    {
        [JsonProperty("home_points")]
        public long HomePoints { get; set; }

        [JsonProperty("away_points")]
        public long AwayPoints { get; set; }

        [JsonProperty("periods")]
        public Period[] Periods { get; set; }

        [JsonProperty("period_type")]
        public string PeriodType { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

    }
}
