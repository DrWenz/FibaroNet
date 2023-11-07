using FibaroNet.Commands.GlobalValues;
using FibaroNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FibaroNet.Commands.GlobalVariables
{
    public class GlobalValueCommands : DefaultCommands
    {
        public GlobalValueCommands(Api api) : base(api) {
        }

        public Task<CommandResult<IList<GlobalValue>>> GetAll() {
            return _api.SendCommandAsync(new GetGlobalVariablesCommand());
        }

        public Task<CommandResult<GlobalValue>> GetByName(string name) {
            return _api.SendCommandAsync(new GetGlobalValueByNameCommand(name));
        }

        public Task<CommandResult<string>> Update(string name, string value) {
            return _api.SendCommandAsync(new UpdateGlobalVariablesCommand(name, value));
        }
    }
}
