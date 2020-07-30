using Bridge.Interface;

namespace Bridge.Abstraction
{
    abstract class NotificationSender
    {
        public Notification _notification;            
        public INotificationSender _notificationSender { get; set; }
        public abstract void SendNotification();

        public NotificationSender()
        {
            _notification = new Notification();
        }
    }
}
