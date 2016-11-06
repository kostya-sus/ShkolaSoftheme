using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HW18_Mobile
{
    public delegate void MobileAccountHandler(object sender, MobileEventArgs mEvent);

    public class MobileAccount
    {
        private readonly int _number;
        private readonly MobileOperator _operator;
        private readonly string _name;
        public int Balance { get; set; }
        private int _callPrice;
        private int _messagePrice;

        public event MobileAccountHandler SentSMS;
        public event MobileAccountHandler MadeCall;

        public List<Contact> Contacts { get; }

        public MobileAccount(MobileOperator mobileOperator, int balance,int callPrice,int messagePrice)
        {
            _operator = mobileOperator;
            _number = _operator.GiveNumber();
            _operator.AccountRegistration(this);
            _name = "account"+_number ;
            Balance = balance;
            _callPrice = callPrice;
            _messagePrice = messagePrice;




            Contacts = new List<Contact>();
        }

        public int AddBalance(int money)
        {
            return Balance += money;
        }

        public int Number
        {
            get { return _number; }
        }

        public string Name
        {
            get { return _name; }
        }

        public MobileOperator Operator
        {
            get { return _operator; }
        }

        public void AddContact(string name, MobileAccount account)
        {
            Contacts.Add(new Contact { Name = name, Account = account });
        }

        public void DeleteContact(MobileAccount account)
        {
            Contacts.Remove(Contacts.Where(i => i.Account == account).ToArray()[0]);
        }

        [OperatorMessage(Level.Warn)]
        public void SendMessage(MobileAccount forWhom, string message)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            Level level = OperatorMessageAttribute.GetAttributeInfo(method);
            if (Balance >= _messagePrice)
            {
                if (SentSMS != null)
                {
                    SentSMS(this, new MobileEventArgs(MobileOperation.Message, forWhom, message));
                    Balance -= _messagePrice;
                }
            }
            else
            {
                if (level == Level.Warn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's not enought money to send message to {0}!", forWhom);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        [OperatorMessage(Level.Warn)]
        public void MakeCall(MobileAccount forWhom)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            Level level = OperatorMessageAttribute.GetAttributeInfo(method);

            if (Balance >= _callPrice)
            {
                if (MadeCall != null)
                {
                    MadeCall(this, new MobileEventArgs(MobileOperation.Call, forWhom));
                    Balance -= _callPrice;
                }

            }
            else
            {
                if (level == Level.Warn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's not enought money to make call to {0}!", forWhom);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void Notification(object sender, MobileEventArgs e)
        {
            var account = sender as MobileAccount;

            if (e.Operation == MobileOperation.Message)
            {
                IncomingSMS(account, e.Message);
            }
            else if (e.Operation == MobileOperation.Call)
            {
                IncomingCall(account);
            }
        }

        private void IncomingSMS(MobileAccount from, string message)
        {
            var existNumber = Contacts.Where(i => i.Account == from).ToArray();

            Console.WriteLine("{0} received Message!", this);
            Console.WriteLine("From: {0}", existNumber.Length != 0 ? existNumber[0].Name : from.ToString());
            Console.WriteLine("Text: {0}", message);
        }

        private void IncomingCall(MobileAccount from)
        {
            var existNumber = Contacts.Where(i => i.Account == from).ToArray();

            Console.WriteLine("Incoming Call to {0}!", this);
            Console.WriteLine("From: {0}", existNumber.Length != 0 ? existNumber[0].Name : from.ToString());
        }

        public static void contactsBook(MobileAccount account)
        {
            foreach (var contact in account.Contacts)
            {
                Console.WriteLine("{0}: {1}", contact.Name, contact.Account);
            }
        }

        public override string ToString()
        {
            return string.Format("+38({0}){1} - {2}", _operator.OperatorCode, _number,_operator.OperatorName);
        }
    }
}
