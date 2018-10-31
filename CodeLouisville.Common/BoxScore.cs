using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CodeLouisville.Common
{
    public partial class BoxScore
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("scheduled")]
        public DateTimeOffset Scheduled { get; set; }

        [JsonProperty("attendance")]
        public long Attendance { get; set; }

        [JsonProperty("utc_offset")]
        public long UtcOffset { get; set; }

        [JsonProperty("entry_mode")]
        public string EntryMode { get; set; }

        [JsonProperty("weather")]
        public string Weather { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("quarter")]
        public long Quarter { get; set; }

        [JsonProperty("sr_id")]
        public string SrId { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("situation")]
        public Situation Situation { get; set; }

        [JsonProperty("last_event")]
        public LastEvent LastEvent { get; set; }

        [JsonProperty("scoring")]
        public Scoring[] Scoring { get; set; }

        [JsonProperty("scoring_drives")]
        public ScoringDrive[] ScoringDrives { get; set; }

        [JsonProperty("scoring_plays")]
        public ScoringPlay[] ScoringPlays { get; set; }

        [JsonProperty("_comment")]
        public string Comment { get; set; }
    }

    public enum EndReason { FieldGoal, Touchdown };

    public enum DetailCategory { FieldGoal, KickOff, KickOffReturn, PassCompletion, PassIncompletion, PassReception, Penalty, Review, Rush, Tackle, Touchback, Touchdown, TwoPointPass };

    public enum Alias { Ne, Phi };

    public enum Market { NewEngland, Philadelphia };

    public enum Name { Eagles, Patriots };

    public enum SrId { SrCompetitor4424, SrCompetitor4428 };

    public enum Position { Cb, Db, De, Dl, Dt, Fb, K, Lb, Ls, P, Qb, Rb, S, Te, Wr };

    public enum RoleEnum { AstTackle, Catch, Defend, Hit, Hold, Kick, KickReturn, Pass, Penalty, Receive, Return, Rush, Snap, Tackle };

    public enum Result { Good, NoGoodPassIncomplete, PushedOutOfBounds, RanOutOfBounds, Tackled, Touchback, Touchdown };

    public enum HashMark { LeftHash, Middle, RightHash };

    public enum Huddle { Huddle, NoHuddle };

    public enum PlayDirection { Left, LeftSideline, Middle, Right, RightSideline };

    public enum StatTypeEnum { Conversion, Defense, DownConversion, ExtraPoint, FieldGoal, FirstDown, Kick, Kickoff, Pass, Penalty, Receive, Return, Rush };

    public enum PocketLocation { BootLeft, BootRight, Middle, RolloutRight, ScrambleLeft, ScrambleRight };

    public enum QbAtSnap { Shotgun, UnderCenter };

    public enum IncompletionType { DroppedPass, PassDefended, PoorlyThrown };

    public enum PlayType { Play };

}

