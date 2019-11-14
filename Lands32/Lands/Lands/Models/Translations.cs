using Newtonsoft.Json;

namespace Lands.Models
{
    class Translations
    {
        [JsonProperty(PropertyName = "de")]
        public string Germany { get; set; }
        [JsonProperty(PropertyName = "es")]
        public string Espanish { get; set; }
        [JsonProperty(PropertyName = "fr")]
        public string French { get; set; }
        [JsonProperty(PropertyName = "ja")]
        public string Japanese { get; set; }
        [JsonProperty(PropertyName = "it")]
        public string Italian { get; set; }
        [JsonProperty(PropertyName = "br")]
        public string Brazilian { get; set; }
        [JsonProperty(PropertyName = "pt")]
        public string Portugue { get; set; }
        [JsonProperty(PropertyName = "nl")]
        public string Dutsh { get; set; }
        [JsonProperty(PropertyName = "hr")]
        public string Croatian { get; set; }
        [JsonProperty(PropertyName = "fa")]
        public string Persia { get; set; }
    }
}
