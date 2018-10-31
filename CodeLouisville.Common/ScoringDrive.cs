using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class ScoringDrive
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("start_reason")]
        public string StartReason { get; set; }

        [JsonProperty("end_reason")]
        public EndReason EndReason { get; set; }

        [JsonProperty("play_count")]
        public long PlayCount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("first_downs")]
        public long FirstDowns { get; set; }

        [JsonProperty("gain")]
        public long Gain { get; set; }

        [JsonProperty("penalty_yards")]
        public long PenaltyYards { get; set; }

        [JsonProperty("inside_20", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inside20 { get; set; }

        [JsonProperty("scoring_drive")]
        public bool ScoringDriveScoringDrive { get; set; }

        [JsonProperty("quarter")]
        public Quarter Quarter { get; set; }

        [JsonProperty("team")]
        public LocationClass Team { get; set; }

        [JsonProperty("plays")]
        public Play[] Plays { get; set; }
    }
}
