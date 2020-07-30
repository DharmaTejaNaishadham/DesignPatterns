using System;
using Bridge.Concrete_Implementation;
using Bridge.Refined_Abstraction;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailNotificationSender emailNotificationSender = new EmailNotificationSender();
            SMSNotificationSender smsNotificationSender = new SMSNotificationSender();
            UINotificationSender uiNotificationSender = new UINotificationSender();

            CreditSystem creditSystem = new CreditSystem();
            DebitSystem debitSystem = new DebitSystem();
            PromotionSystem promotionSystem = new PromotionSystem();

            Account account = new Account()
            {
                AccountName = "Dumpi",
                Balance = 0
            };

            ////////////////////////////////////////////////////////////////////////////////////////////
            creditSystem._notificationSender = emailNotificationSender;
            creditSystem.Credit(account, 100);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            creditSystem._notificationSender = smsNotificationSender;
            creditSystem.Credit(account, 100);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            creditSystem._notificationSender = uiNotificationSender;
            creditSystem.Credit(account, 100);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////            
            debitSystem._notificationSender = emailNotificationSender;
            debitSystem.Debit(account, 100);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            debitSystem._notificationSender = smsNotificationSender;
            debitSystem.Debit(account, 100);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            debitSystem._notificationSender = uiNotificationSender;
            debitSystem.Debit(account, 200);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////
            string offer = "$1 million loan approved";

            promotionSystem._notificationSender = emailNotificationSender;
            promotionSystem.Promote(account, offer);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            promotionSystem._notificationSender = smsNotificationSender;
            promotionSystem.Promote(account, offer);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            promotionSystem._notificationSender = uiNotificationSender;
            promotionSystem.Promote(account, offer);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");
            ////////////////////////////////////////////////////////////////////////////////////////////


            //Just to stop the console
            Console.ReadLine();
        }
    }
}
