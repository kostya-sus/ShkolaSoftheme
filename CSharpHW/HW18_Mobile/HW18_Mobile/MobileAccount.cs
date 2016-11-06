using System;
using System.Collections.Generic;
using System.Linq;


namespace HW18_Mobile
{
    public delegate void MobileAccountHandler(object sender, MobileEventArgs mEvent);

    public class MobileAccount
    {
        private readonly int _number;
        private readonly MobileOperator _operator;
        private readonly string _name;

        public event MobileAccountHandler SentSMS;
        public event MobileAccountHandler MadeCall;

        public List<Contact> Contacts { get; }

        public MobileAccount(MobileOperator mobileOperator)
        {
            _operator = mobileOperator;
            _number = _operator.GiveNumber();
            _operator.AccountRegistration(this);
            _name = "account"+_number ;

            Contacts = new List<Contact>();
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

        public void SendSMS(MobileAccount forWhom, string message)
        {
            if (SentSMS != null)
            {
                SentSMS(this, new MobileEventArgs(MobileOperation.SMS, forWhom, message));
            }
        }

        public void MakeCall(MobileAccount forWhom)
        {
            if (MadeCall != null)
            {
                MadeCall(this, new MobileEventArgs(MobileOperation.Call, forWhom));
            }
        }

        public void Notification(object sender, MobileEventArgs e)
        {
            var account = sender as MobileAccount;

            if (e.Operation == MobileOperation.SMS)
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

            Console.WriteLine("{0} received SMS!", this);
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
