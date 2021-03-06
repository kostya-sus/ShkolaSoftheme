﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace HW18_Mobile
{
     public class MobileOperator
    {
        private readonly string _numberCode;
        private readonly string _nameOperator;
        private readonly List<int> _phoneNumber;
        private AccountsStorage _storage;

        private History _history;

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

        public void StartHistory(History history)
        {
            _history = history;
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
            if (_history == null)
            {
                _history = new History();
            }

            mEvent.ForWhom.Notification(sender, mEvent);
            _history.RegisterMessage(new Messages(sender as MobileAccount, mEvent.ForWhom));
        }

        public void Call(object sender, MobileEventArgs mEvent)
        {
            if (_history == null)
            {
                _history = new History();
            }

            mEvent.ForWhom.Notification(sender, mEvent);
            _history.RegisterCall(new Calls(sender as MobileAccount, mEvent.ForWhom));
        }
                
    }
}
