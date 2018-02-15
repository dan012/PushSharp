using System;

namespace PushSharp.Apple
{
    public interface IServiceConnectionFactory<TNotification> where TNotification : INotification
    {
        IServiceConnection<TNotification> Create();
    }
}

