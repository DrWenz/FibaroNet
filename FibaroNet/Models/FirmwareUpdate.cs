namespace FibaroNet.Models
{
    public class FirmwareUpdate
    {
        public string UpdateVersion { get; set; }
        public int Progress { get; set; }
        public string Info { get; set; }
        public string Status { get; set; }
    }
}
