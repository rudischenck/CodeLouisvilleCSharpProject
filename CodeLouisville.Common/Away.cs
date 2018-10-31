using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Away
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("game_number")]
        public long GameNumber { get; set; }

        [JsonProperty("sr_id")]
        public string SrId { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("used_timeouts")]
        public long UsedTimeouts { get; set; }

        [JsonProperty("remaining_timeouts")]
        public long RemainingTimeouts { get; set; }

        [JsonProperty("points")]
        public long Points { get; set; }


    }
}
