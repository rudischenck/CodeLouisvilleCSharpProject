using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class PointsAfterPlay
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("sequence")]
        public double Sequence { get; set; }

        [JsonProperty("reference")]
        public long Reference { get; set; }

        [JsonProperty("type")]
        public StatTypeEnum Type { get; set; }
    }
}
