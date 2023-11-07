using System;

namespace FibaroNet.Commands
{
    public class CommandResult<TResult> where TResult : class
    {
        public bool Success { get; }
        public TimeSpan Duration { get; }
        public TResult Data { get; }
        public string Message { get; }

        private CommandResult(bool success, TimeSpan duration, TResult data, string message) {
            Success = success;
            Duration = duration;
            Data = data;
            Message = message;
        }

        internal static CommandResult<TResult> FromSuccess(TimeSpan timeSpan, TResult data, string message = "") {
            return new CommandResult<TResult>(true, timeSpan, data, message);
        }

        internal static CommandResult<TResult> FromError(TimeSpan timeSpan, string message = "") {
            return new CommandResult<TResult>(false, timeSpan, default, message);
        }
    }
}
