using Bridge.Abstraction;

namespace Bridge.Refined_Abstraction
{
    class CreditSystem : NotificationSender
    {
        public void Credit(Account account, int money)
        {
            account.Balance += money;
            PrepareNotification(account, string.Concat("$", money.ToString(), " has been credited to your account."));
        }
        
        public void PrepareNotification(Account account, string content)
        {
            _notification.To = account.AccountName;
            _notification.Subject = "Money Credit Alert";
            _notification.Body = string.Concat(content, " Your current balance is $", account.Balance.ToString());
            SendNotification();
        }

        public override void SendNotification()
        {
            _notificationSender.SendNotification(_notification);
        }
    }
}
