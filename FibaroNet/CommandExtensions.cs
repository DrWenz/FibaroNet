using FibaroNet.Commands;
using System.Threading.Tasks;

namespace FibaroNet
{
    public static class CommandExtensions
    {
        /// <summary>
        /// If the <see cref="CommandResult.Success"/> is true, returns the <see cref="CommandResult.Data"/>, other returns null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public static async Task<T> AsDataObject<T>(this Task<CommandResult<T>> command) where T : class {
            var res = await command;
            return res.Success ? res.Data : default;
        }
    }
}
