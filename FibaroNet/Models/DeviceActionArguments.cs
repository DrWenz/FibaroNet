using System.Collections.Generic;

namespace FibaroNet.Models
{
    public sealed class DeviceActionArguments
    {
        public IEnumerable<object> Args { get; set; }
        public int Delay { get; set; }
        public string IntegrationPin { get; set; }
    }
}
