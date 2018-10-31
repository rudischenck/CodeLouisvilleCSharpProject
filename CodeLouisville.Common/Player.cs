using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Player
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("jersey")]
        public string Jersey { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("sr_id")]
        public string SrId { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum? Role { get; set; }
    }
}
