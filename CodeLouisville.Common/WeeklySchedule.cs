// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var weeklySchedule = WeeklySchedule.FromJson(jsonString);
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CodeLouisville.Common
{

    public partial class WeeklySchedule
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

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum EntryMode { Ingest };

    public enum PeriodType { Overtime, Quarter };

    public enum Status { Closed };

    public enum Country { Usa, UK };

    public enum RoofType { Dome, Outdoor, RetractableDome };

    public enum Surface { Artificial, Turf };

}









