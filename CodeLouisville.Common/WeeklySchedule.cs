//the main data structure, contains information that will be used to retrieve scoring information.

using System;
using Newtonsoft.Json;

namespace CodeLouisville.Common
{

    public partial class WeeklySchedule : IEquatable<WeeklySchedule>
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("week")]
        public Week Week { get; set; }

        [JsonProperty("_comment")]
        public string Comment { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            WeeklySchedule objAsWeeklySchedule = obj as WeeklySchedule;
            if (objAsWeeklySchedule == null) return false;
            else return Equals(objAsWeeklySchedule);

        }
        public override int GetHashCode()
        {
            return Week.Id.GetHashCode();
        }
        public bool Equals(WeeklySchedule other)
        {
            return Week.Id == other.Week.Id;
        }

    }

    public enum EntryMode { Ingest };

    public enum PeriodType { Overtime, Quarter };

    public enum Status { Closed };

    public enum Country { Usa, UK };

    public enum RoofType { Dome, Outdoor, RetractableDome };

    public enum Surface { Artificial, Turf };

}









