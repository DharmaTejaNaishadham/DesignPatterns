using System;
using Bridge.Interface;

namespace Bridge.Concrete_Implementation
{
    class SMSNotificationSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine("SMS sent\nTo - \"{0}\"\nsubject - \"{1}\"\nbody - \"{2}\"", notification.To, notification.Subject, notification.Body);
        }
    }
}
