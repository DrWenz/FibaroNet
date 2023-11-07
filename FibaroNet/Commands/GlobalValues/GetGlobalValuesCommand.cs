using FibaroNet.Models;
using System.Collections.Generic;

namespace FibaroNet.Commands.GlobalVariables
{
    public class GetGlobalVariablesCommand : Command<IList<GlobalValue>>
    {
        public override string Endpoint => "api/globalVariables";
    }
}
