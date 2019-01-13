using Newtonsoft.Json;

namespace MyStrom.Api.Models
{
    public class Network
    {
        public string Name { get; set; }
        public int Signal { get; set; }
        [JsonProperty(PropertyName = "encryption-on")]
        public bool EncryptionOn { get; set; }
        public string Encryption { get; set; }
    }
}