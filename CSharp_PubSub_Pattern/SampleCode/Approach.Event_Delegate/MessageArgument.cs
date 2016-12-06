using System;

namespace Approach.Event_Delegate
{
    public class MessageArgument<T> : EventArgs
    {
        public T Message { get; private set; }
        public MessageArgument(T message)
        {
            Message = message;
        }
    }
}