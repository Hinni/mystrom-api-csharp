namespace MyStrom.Api.Models
{
    public class ConnectionStatus
    {
        public bool Ntp { get; set; }
        public bool Dns { get; set; }
        public bool Connection { get; set; }
        public bool Handshake { get; set; }
        public bool Login { get; set; }
    }
}