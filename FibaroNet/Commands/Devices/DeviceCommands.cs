using FibaroNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FibaroNet.Commands.Devices
{
    public sealed class DeviceCommands : DefaultCommands
    {
        public DeviceCommands(Api api) : base(api) {
        }

        public Task<CommandResult<IList<Device>>> GetAll() {
            return _api.SendCommandAsync(new GetDevicesCommand());
        }

        public Task<CommandResult<Device>> GetById(int deviceId) {
            return _api.SendCommandAsync(new GetDeviceByIdCommand(deviceId));
        }

        public Task<CommandResult<string>> CallAction(int deviceId, string actionName, object arg, int delay = 0) =>
            CallAction(deviceId, actionName, arg != null ? new object[] { arg } : null, delay);

        public Task<CommandResult<string>> CallAction(int deviceId, string actionName, object[] args = null, int delay = 0) {
            return _api.SendCommandAsync(new CallDeviceActionCommand(deviceId, actionName, args, delay));
        }
    }
}
