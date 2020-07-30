using System;
using Bridge.Interface;

namespace Bridge.Concrete_Implementation
{
    class UINotificationSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine("UI Alert sent\nTo - \"{0}\"\nsubject - \"{1}\"\nbody - \"{2}\"", notification.To, notification.Subject, notification.Body);
        }
    }
}
