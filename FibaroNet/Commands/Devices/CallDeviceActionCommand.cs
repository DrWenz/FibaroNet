using FibaroNet.Models;
using System.Net.Http;

namespace FibaroNet.Commands.Devices
{
    public sealed class CallDeviceActionCommand : Command
    {
        public override string Endpoint => $"api/devices/{DeviceId}/action/{ActionName}";
        public override HttpMethod Method => HttpMethod.Post;
        public int DeviceId { get; }
        public string ActionName { get; }

        public CallDeviceActionCommand(int deviceId, string actionName, object[] args = null, int delay = 0, string integrationPin = null) {
            DeviceId = deviceId;
            ActionName = actionName;
            Content = new DeviceActionArguments {
                Args = args,
                Delay = delay,
                IntegrationPin = integrationPin
            };
        }
    }
}
