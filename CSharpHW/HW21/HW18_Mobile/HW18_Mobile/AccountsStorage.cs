using System;
using System.Collections.Generic;

namespace HW18_Mobile
{
   
    public class AccountsStorage
    {
      
        private Dictionary<int, MobileAccount> _storage;
    
        public AccountsStorage()
        {
            _storage = new Dictionary<int, MobileAccount>();
        }

        public void AddAccount(MobileAccount account)
        {
            if (!IsExistAccount(account))
            {
                _storage.Add(account.ToString().GetHashCode(), account);
            }
        }

        public void RemoveAccount(MobileAccount account)
        {
            _storage.Remove(account.ToString().GetHashCode());
        }

        public bool IsExistAccount(MobileAccount account)
        {
            return _storage.ContainsKey(account.ToString().GetHashCode());
        }
    }
}
