using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class PlayStatistic
    {
        [JsonProperty("stat_type")]
        public StatTypeEnum StatType { get; set; }

        [JsonProperty("attempt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Attempt { get; set; }

        [JsonProperty("yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? Yards { get; set; }

        [JsonProperty("onside_attempt", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnsideAttempt { get; set; }

        [JsonProperty("onside_success", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnsideSuccess { get; set; }

        [JsonProperty("squib_kick", NullValueHandling = NullValueHandling.Ignore)]
        public long? SquibKick { get; set; }

        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public Player Player { get; set; }

        [JsonProperty("team")]
        public LocationClass Team { get; set; }

        [JsonProperty("return", NullValueHandling = NullValueHandling.Ignore)]
        public long? Return { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum? Category { get; set; }

        [JsonProperty("tackle", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tackle { get; set; }

        [JsonProperty("missed_tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long? MissedTackles { get; set; }

        [JsonProperty("def_target", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefTarget { get; set; }

        [JsonProperty("def_comp", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefComp { get; set; }

        [JsonProperty("blitz", NullValueHandling = NullValueHandling.Ignore)]
        public long? Blitz { get; set; }

        [JsonProperty("hurry", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hurry { get; set; }

        [JsonProperty("knockdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Knockdown { get; set; }

        [JsonProperty("complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? Complete { get; set; }

        [JsonProperty("att_yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttYards { get; set; }

        [JsonProperty("firstdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Firstdown { get; set; }

        [JsonProperty("inside_20", NullValueHandling = NullValueHandling.Ignore)]
        public long? Inside20 { get; set; }

        [JsonProperty("goaltogo", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goaltogo { get; set; }

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

        [JsonProperty("yards_after_contact", NullValueHandling = NullValueHandling.Ignore)]
        public long? YardsAfterContact { get; set; }

        [JsonProperty("down", NullValueHandling = NullValueHandling.Ignore)]
        public long? Down { get; set; }

        [JsonProperty("tlost", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tlost { get; set; }

        [JsonProperty("tlost_yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? TlostYards { get; set; }

        [JsonProperty("broken_tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long? BrokenTackles { get; set; }

        [JsonProperty("kneel_down", NullValueHandling = NullValueHandling.Ignore)]
        public long? KneelDown { get; set; }

        [JsonProperty("scramble", NullValueHandling = NullValueHandling.Ignore)]
        public long? Scramble { get; set; }

        [JsonProperty("incompletion_type", NullValueHandling = NullValueHandling.Ignore)]
        public IncompletionType? IncompletionType { get; set; }

        [JsonProperty("pass_defended", NullValueHandling = NullValueHandling.Ignore)]
        public long? PassDefended { get; set; }

        [JsonProperty("ast_tackle", NullValueHandling = NullValueHandling.Ignore)]
        public long? AstTackle { get; set; }

        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public long? Primary { get; set; }

        [JsonProperty("penalty", NullValueHandling = NullValueHandling.Ignore)]
        public long? Penalty { get; set; }

        [JsonProperty("missed", NullValueHandling = NullValueHandling.Ignore)]
        public long? Missed { get; set; }

        [JsonProperty("gross_yards", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrossYards { get; set; }

        [JsonProperty("touchback", NullValueHandling = NullValueHandling.Ignore)]
        public long? Touchback { get; set; }

        [JsonProperty("nullified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nullified { get; set; }

        [JsonProperty("touchdown", NullValueHandling = NullValueHandling.Ignore)]
        public long? Touchdown { get; set; }

        [JsonProperty("qb_hit", NullValueHandling = NullValueHandling.Ignore)]
        public long? QbHit { get; set; }

        [JsonProperty("endzone", NullValueHandling = NullValueHandling.Ignore)]
        public long? Endzone { get; set; }
    }
}
