using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class ScoringPlayStatistic
    {
        [JsonProperty("stat_type")]
        public StatTypeEnum StatType { get; set; }

        [JsonProperty("attempt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attempt { get; set; }

        [JsonProperty("att_yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttYards { get; set; }

        [JsonProperty("yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? Yards { get; set; }

        [JsonProperty("missed", NullValueHandling = NullValueHandling.Ignore)]
        public long? Missed { get; set; }

        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public Player Player { get; set; }

        [JsonProperty("team")]
        public LocationClass Team { get; set; }

        [JsonProperty("complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? Complete { get; set; }

        [JsonProperty("firstdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Firstdown { get; set; }

        [JsonProperty("touchdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Touchdown { get; set; }

        [JsonProperty("inside_20", NullValueHandling = NullValueHandling.Ignore)]
        public long? Inside20 { get; set; }

        [JsonProperty("goaltogo", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goaltogo { get; set; }

        [JsonProperty("blitz", NullValueHandling = NullValueHandling.Ignore)]
        public long? Blitz { get; set; }

        [JsonProperty("hurry", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hurry { get; set; }

        [JsonProperty("knockdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Knockdown { get; set; }

        [JsonProperty("pocket_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? PocketTime { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public long? Target { get; set; }

        [JsonProperty("reception", NullValueHandling = NullValueHandling.Ignore)]
        public long? Reception { get; set; }

        [JsonProperty("yards_after_catch", NullValueHandling = NullValueHandling.Ignore)]
        public long? YardsAfterCatch { get; set; }

        [JsonProperty("dropped", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dropped { get; set; }

        [JsonProperty("catchable", NullValueHandling = NullValueHandling.Ignore)]
        public long? Catchable { get; set; }

        [JsonProperty("missed_tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long? MissedTackles { get; set; }

        [JsonProperty("def_target", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefTarget { get; set; }

        [JsonProperty("def_comp", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefComp { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum? Category { get; set; }

        [JsonProperty("broken_tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long? BrokenTackles { get; set; }

        [JsonProperty("kneel_down", NullValueHandling = NullValueHandling.Ignore)]
        public long? KneelDown { get; set; }

        [JsonProperty("scramble", NullValueHandling = NullValueHandling.Ignore)]
        public long? Scramble { get; set; }

        [JsonProperty("yards_after_contact", NullValueHandling = NullValueHandling.Ignore)]
        public long? YardsAfterContact { get; set; }

        [JsonProperty("down", NullValueHandling = NullValueHandling.Ignore)]
        public long? Down { get; set; }

        [JsonProperty("incompletion_type", NullValueHandling = NullValueHandling.Ignore)]
        public IncompletionType? IncompletionType { get; set; }
    }
}
