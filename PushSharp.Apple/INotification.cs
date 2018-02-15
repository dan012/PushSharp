using System;

namespace PushSharp.Apple
{
    public interface INotification
    {
        bool IsDeviceRegistrationIdValid();
        object Tag { get; set; }
    }
}
