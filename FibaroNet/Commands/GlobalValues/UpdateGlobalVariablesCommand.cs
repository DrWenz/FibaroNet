using System.Net.Http;

namespace FibaroNet.Commands.GlobalValues
{
    public class UpdateGlobalVariablesCommand : Command
    {
        public override string Endpoint => $"api/globalVariables/{Name}";
        public override HttpMethod Method => HttpMethod.Put;

        public string Name { get; }

        public UpdateGlobalVariablesCommand(string name, string value) {
            Name = name;
            Content = new { value };
        }
    }
}
