using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18_Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            History history = new History();

            MobileOperator mOperator1 = new MobileOperator("096","Kievstar");
            MobileOperator mOperator2 = new MobileOperator("097", "Kievstar");
            MobileOperator mOperator3 = new MobileOperator("098", "Kievstar");
           

            mOperator1.StartHistory(history);
            mOperator2.StartHistory(history);
            mOperator3.StartHistory(history);

            MobileAccount account1 = new MobileAccount(mOperator1,40,5,5);
            MobileAccount account2 = new MobileAccount(mOperator1,40, 5, 5);
            MobileAccount account3 = new MobileAccount(mOperator1, 15, 5, 5);
            MobileAccount account4 = new MobileAccount(mOperator2, 10, 5, 5);
            MobileAccount account5 = new MobileAccount(mOperator3, 40, 5, 5);
            MobileAccount account6 = new MobileAccount(mOperator3, 40, 5, 5);
            MobileAccount account7 = new MobileAccount(mOperator3, 40, 5, 5);

            account4.AddBalance(50);
            account1.AddContact(account2.Name, account2);
            account1.AddContact(account3.Name, account3);
         
            account2.AddContact(account1.Name, account1);
            account2.AddContact(account3.Name, account3);
           
            account3.AddContact(account1.Name, account1);
            account3.AddContact(account2.Name, account2);

            account4.AddContact(account1.Name, account1);
            account4.AddContact(account2.Name, account2);
            account4.AddContact(account3.Name, account3);
            account4.AddContact(account4.Name, account4);
            account4.AddContact(account5.Name, account5);
            account4.AddContact(account6.Name, account6);
            account4.AddContact(account7.Name, account7);

            Console.WriteLine("Contacts {0}",account1.Name);
            MobileAccount.contactsBook(account1);

            Console.WriteLine("Contacts {0}", account2.Name);
            MobileAccount.contactsBook(account2);

            Console.WriteLine("Contacts {0}", account3.Name);
            MobileAccount.contactsBook(account3);

            Console.WriteLine("Contacts {0}", account4.Name);
            MobileAccount.contactsBook(account4);

            Console.WriteLine("");

            account1.SendMessage(account2, "Message");
            Console.WriteLine("");
            account3.MakeCall(account1);
            Console.WriteLine("");
            account2.SendMessage(account1, "Message1");
            Console.WriteLine("");

            account4.SendMessage(account2, "Message2");
            Console.WriteLine("");

            account4.SendMessage(account2, "Message2");
            Console.WriteLine("");
            account4.SendMessage(account2, "Message2");
            Console.WriteLine("");

            account3.MakeCall(account1);
            Console.WriteLine("");
            account3.MakeCall(account4);
            Console.WriteLine("");
            account3.MakeCall(account2);
            Console.WriteLine("");

            Console.WriteLine("Most frequently called numbers:");
            foreach (var account in history.TopCalledNumbers(5))
            {
                Console.WriteLine(account);
            }

            Console.WriteLine("Most active subscribers:");
            foreach (var account in history.FrequentlyActiveSubscribers(5))
            {
                Console.WriteLine(account);
            }


            Console.ReadKey();
        }

     
    }
}
