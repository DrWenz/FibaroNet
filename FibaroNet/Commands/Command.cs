using System;
using System.Net.Http;

namespace FibaroNet.Commands
{
    public abstract class Command<TResult> : ICommand<TResult> where TResult : class
    {
        public virtual string Endpoint => throw new NotImplementedException();

        public virtual HttpMethod Method => HttpMethod.Get;

        public object Content { get; set; }

        public virtual void Prepare() {
        }

        public virtual T TransformResult<T>(T result) {
            return result;
        }
    }

    public class Command : Command<string>
    {

    }
}
