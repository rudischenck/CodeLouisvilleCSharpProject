using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Play
    {
        [JsonProperty("type")]
        public PlayType Type { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("home_points")]
        public long HomePoints { get; set; }

        [JsonProperty("away_points")]
        public long AwayPoints { get; set; }

        [JsonProperty("play_type")]
        public StatTypeEnum PlayType { get; set; }

        [JsonProperty("play_clock")]
        public long PlayClock { get; set; }

        [JsonProperty("wall_clock")]
        public DateTimeOffset WallClock { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alt_description")]
        public string AltDescription { get; set; }

        [JsonProperty("fake_punt")]
        public bool FakePunt { get; set; }

        [JsonProperty("fake_field_goal")]
        public bool FakeFieldGoal { get; set; }

        [JsonProperty("screen_pass")]
        public bool ScreenPass { get; set; }

        [JsonProperty("hash_mark", NullValueHandling = NullValueHandling.Ignore)]
        public HashMark? HashMark { get; set; }

        [JsonProperty("start_situation")]
        public Situation StartSituation { get; set; }

        [JsonProperty("end_situation")]
        public Situation EndSituation { get; set; }

        [JsonProperty("statistics")]
        public PlayStatistic[] Statistics { get; set; }

        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public PlayDetail[] Details { get; set; }

        [JsonProperty("quarter")]
        public Quarter Quarter { get; set; }

        [JsonProperty("players_rushed", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayersRushed { get; set; }

        [JsonProperty("men_in_box", NullValueHandling = NullValueHandling.Ignore)]
        public long? MenInBox { get; set; }

        [JsonProperty("blitz", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Blitz { get; set; }

        [JsonProperty("play_direction", NullValueHandling = NullValueHandling.Ignore)]
        public PlayDirection? PlayDirection { get; set; }

        [JsonProperty("left_tightends", NullValueHandling = NullValueHandling.Ignore)]
        public long? LeftTightends { get; set; }

        [JsonProperty("right_tightends", NullValueHandling = NullValueHandling.Ignore)]
        public long? RightTightends { get; set; }

        [JsonProperty("pocket_location", NullValueHandling = NullValueHandling.Ignore)]
        public PocketLocation? PocketLocation { get; set; }

        [JsonProperty("qb_at_snap", NullValueHandling = NullValueHandling.Ignore)]
        public QbAtSnap? QbAtSnap { get; set; }

        [JsonProperty("huddle", NullValueHandling = NullValueHandling.Ignore)]
        public Huddle? Huddle { get; set; }

        [JsonProperty("pass_route", NullValueHandling = NullValueHandling.Ignore)]
        public string PassRoute { get; set; }

        [JsonProperty("running_lane", NullValueHandling = NullValueHandling.Ignore)]
        public long? RunningLane { get; set; }

        [JsonProperty("goaltogo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Goaltogo { get; set; }

        [JsonProperty("scoring_play", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScoringPlay { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public Score Score { get; set; }
    }
}
