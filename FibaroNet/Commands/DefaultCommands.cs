namespace FibaroNet.Commands
{
    public abstract class DefaultCommands
    {
        protected readonly Api _api;

        internal DefaultCommands(Api api) {
            _api = api;
        }
    }
}
