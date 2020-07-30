using Bridge.Abstraction;

namespace Bridge.Refined_Abstraction
{
    class DebitSystem : NotificationSender
    {
        public void Debit(Account account, int money)
        {
            if(account.Balance >= money)
            {
                account.Balance -= money;
                PrepareNotification(account, string.Concat("$", money.ToString(), " has been debited from your account."));
            }
            else
            {
                PrepareNotification(account, string.Concat("Insufficient Funds! $", money.ToString(), " couldn't be debited from your account."));
            }            
        }

        public void PrepareNotification(Account account, string content)
        {
            _notification.To = account.AccountName;
            _notification.Subject = "Money Debit Alert";
            _notification.Body = string.Concat(content, " Your current balance is $", account.Balance.ToString());
            SendNotification();
        }

        public override void SendNotification()
        {
            _notificationSender.SendNotification(_notification);
        }
    }
}
