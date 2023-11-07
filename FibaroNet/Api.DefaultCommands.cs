using FibaroNet.Commands.Devices;
using FibaroNet.Commands.GlobalVariables;
using FibaroNet.Commands.Rooms;
using System;

namespace FibaroNet
{
    public sealed partial class Api : IDisposable
    {
        private void CreateDefaultCommands() {
            Device = new DeviceCommands(this);
            Room = new RoomCommands(this);
            GlobalValue = new GlobalValueCommands(this);
        }

        /// <summary>
        /// Default device commands
        /// </summary>
        public DeviceCommands Device { get; private set; }

        /// <summary>
        /// Default room commands
        /// </summary>
        public RoomCommands Room { get; private set; }

        /// <summary>
        /// Default GlobalValue commands
        /// </summary>
        public GlobalValueCommands GlobalValue { get; private set; }
    }
}
