using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Review
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
