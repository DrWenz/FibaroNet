using FibaroNet.Models;

namespace FibaroNet.Commands.GlobalVariables
{
    public class GetGlobalValueByNameCommand : Command<GlobalValue>
    {
        public override string Endpoint => $"api/globalVariables/{Name}";
        public string Name { get; }

        public GetGlobalValueByNameCommand(string name) {
            Name = name;
        }
    }
}
