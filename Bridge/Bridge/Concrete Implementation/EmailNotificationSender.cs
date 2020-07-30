using System;
using Bridge.Interface;

namespace Bridge.Concrete_Implementation
{
    class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine("Email sent\nTo - \"{0}\"\nsubject - \"{1}\"\nbody - \"{2}\"", notification.To, notification.Subject, notification.Body);
        }
    }
}
