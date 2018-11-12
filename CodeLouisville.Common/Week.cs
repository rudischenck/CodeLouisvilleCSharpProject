using Newtonsoft.Json;

namespace CodeLouisville.Common
{
    public partial class Week
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("title")]
        public long Title { get; set; }

        [JsonProperty("games")]
        public Game[] Games { get; set; }
    }
}
