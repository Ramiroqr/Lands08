namespace Land.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    class Land
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<string> topLevelDomain { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string alpha2Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string alpha3Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<string> callingCodes { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string capital { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<string> altSpellings { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string region { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string subregion { get; set; }
        [JsonProperty(PropertyName = "name")]
        public int population { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<double> latlng { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string demonym { get; set; }
        [JsonProperty(PropertyName = "name")]
        public double area { get; set; }
        [JsonProperty(PropertyName = "name")]
        public double gini { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<string> timezones { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<string> borders { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string nativeName { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string numericCode { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<Currency> currencies { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<Language> languages { get; set; }
        [JsonProperty(PropertyName = "name")]
        public Translations translations { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string flag { get; set; }
        [JsonProperty(PropertyName = "name")]
        public List<RegionalBloc> regionalBlocs { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string cioc { get; set; }
    }
}
