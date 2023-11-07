using FibaroNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FibaroNet.Commands.Rooms
{
    public sealed class RoomCommands : DefaultCommands
    {
        public RoomCommands(Api api) : base(api) {
        }

        public Task<CommandResult<IList<Room>>> GetAll() {
            return _api.SendCommandAsync(new GetRoomsCommand());
        }

        public Task<CommandResult<Room>> GetById(int roomId) {
            return _api.SendCommandAsync(new GetRoomByIdCommand(roomId));
        }
    }
}
