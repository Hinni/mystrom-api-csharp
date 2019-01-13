namespace MyStrom.Api.Models
{
    public class Info
    {
        public string Version { get; set; }
        public string Mac { get; set; }
        public string Ssid { get; set; }
        public string Ip { get; set; }
        public string Mask { get; set; }
        public string Gateway { get; set; }
        public string Dns { get; set; }
        public bool Static { get; set; }
        public bool Connected { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
    }
}