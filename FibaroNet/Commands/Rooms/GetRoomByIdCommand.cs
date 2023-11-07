using FibaroNet.Models;

namespace FibaroNet.Commands.Rooms
{
    public sealed class GetRoomByIdCommand : Command<Room>
    {
        public override string Endpoint => $"api/rooms/{RoomId}";
        public int RoomId { get; }

        public GetRoomByIdCommand(int roomId) {
            RoomId = roomId;
        }
    }
}
