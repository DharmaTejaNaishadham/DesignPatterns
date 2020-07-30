using Bridge.Abstraction;

namespace Bridge.Refined_Abstraction
{
    class PromotionSystem : NotificationSender
    {
        public void Promote(Account account, string offer)
        {            
            PrepareNotification(account, offer);
        }

        public void PrepareNotification(Account account, string content)
        {
            _notification.To = account.AccountName;
            _notification.Subject = "Great Offer!!!";
            _notification.Body = content;
            SendNotification();
        }

        public override void SendNotification()
        {
            _notificationSender.SendNotification(_notification);
        }
    }
}
