using FibaroNet.Models;

namespace FibaroNet.Commands.Devices
{
    public sealed class GetDeviceByIdCommand : Command<Device>
    {
        public override string Endpoint => $"api/devices/{DeviceId}";
        public int DeviceId { get; }

        public GetDeviceByIdCommand(int deviceId) {
            DeviceId = deviceId;
        }
    }
}
