using FibaroNet.Models;
using System.Collections.Generic;

namespace FibaroNet.Commands.Devices
{
    public sealed class GetDevicesCommand : Command<IList<Device>>
    {
        public override string Endpoint => "api/devices";
    }
}
