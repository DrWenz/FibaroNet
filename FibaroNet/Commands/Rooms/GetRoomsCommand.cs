using FibaroNet.Models;
using System.Collections.Generic;

namespace FibaroNet.Commands.Rooms
{
    public sealed class GetRoomsCommand : Command<IList<Room>>
    {
        public override string Endpoint => "api/rooms";
    }
}
