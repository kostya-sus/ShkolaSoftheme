using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;


namespace HW18_Mobile
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class MobileOperator
    {
        

        private readonly string _numberCode;
     
    
        private readonly string _nameOperator;
    
       
        private readonly List<int> _phoneNumber;
    
        [NonSerialized]
        private AccountsStorage _storage;

        public MobileOperator()
        {
        }

        public MobileOperator(string operatorCode,string name)
        {
            _nameOperator = name;
            _numberCode = operatorCode;
            _phoneNumber = new List<int>();
            _storage = new AccountsStorage();
        }
       
        public string OperatorCode
        {
            get { return _numberCode; }
        }
       
        public string OperatorName
        {
            get { return _nameOperator; }
        }

        public void AccountRegistration(MobileAccount account)
        {
            account.SentSMS += SMS;
            account.MadeCall += Call;
            _storage.AddAccount(account);
        }

        public int GiveNumber()
        {
            Random nuberFilling = new Random();
            int number = nuberFilling.Next(1000000, 10000000);
            Thread.Sleep(20);
            _phoneNumber.Add(number);

            return number;
        }

        public void SMS(object sender, MobileEventArgs mEvent)
        {
            mEvent.ForWhom.Notification(sender, mEvent);
        }

        public void Call(object sender, MobileEventArgs mEvent)
        {
            mEvent.ForWhom.Notification(sender, mEvent);
        }
                
    }
}
