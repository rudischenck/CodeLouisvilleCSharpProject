using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Location
    {
        [JsonProperty("alias")]
        public Alias Alias { get; set; }

        [JsonProperty("yardline")]
        public long Yardline { get; set; }
    }
}
