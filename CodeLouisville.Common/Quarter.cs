using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLouisville.Common
{
    public partial class Quarter
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }
}
