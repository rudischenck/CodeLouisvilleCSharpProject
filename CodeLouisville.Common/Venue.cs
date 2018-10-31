using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Venue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("capacity")]
        public long Capacity { get; set; }

        [JsonProperty("surface")]
        public Surface Surface { get; set; }

        [JsonProperty("roof_type")]
        public RoofType RoofType { get; set; }

        [JsonProperty("sr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrId { get; set; }
    }
}
