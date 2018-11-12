using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Game : IEquatable<Game>
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

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
        public EntryMode EntryMode { get; set; }

        [JsonProperty("weather")]
        public string Weather { get; set; }

        [JsonProperty("sr_id")]
        public string SrId { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("home")]
        public Away Home { get; set; }

        [JsonProperty("away")]
        public Away Away { get; set; }

        [JsonProperty("broadcast")]
        public Broadcast Broadcast { get; set; }

        [JsonProperty("scoring")]
        public Scoring Scoring { get; set; }


        //Print matchup to console

        public string DisplayMatchup()
        {
            return Away.Alias + " @ " + Home.Alias;
        }

        public string DisplayScore()
        {
            return Away.Alias + ": " + Scoring.AwayPoints.ToString() + " " + Home.Alias + ": " + Scoring.HomePoints.ToString();
        }

        public bool Equals(Game other)
        {
            return Id == other.Id;
        }
    }
}
