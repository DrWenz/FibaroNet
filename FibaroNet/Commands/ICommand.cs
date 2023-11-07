using System.Net.Http;

namespace FibaroNet.Commands
{
    public interface ICommand<TResult> where TResult : class
    {
        HttpMethod Method { get; }
        string Endpoint { get; }
        object Content { get; set; }
        void Prepare();
        T TransformResult<T>(T result);
    }
}
