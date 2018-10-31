using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class LocationClass
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("market")]
        public Market Market { get; set; }

        [JsonProperty("alias")]
        public Alias Alias { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("sr_id")]
        public SrId SrId { get; set; }

        [JsonProperty("yardline", NullValueHandling = NullValueHandling.Ignore)]
        public long? Yardline { get; set; }
    }
}
