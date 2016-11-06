using System.Collections.Generic;
using System;


namespace HW16__Dictionary
{
   
    class Dictionary<TKey, TValue> 
    {
        private List<TKey> _key ;
        private List<TValue> _value ;

        public int Count
        {
            get { return _key.Count; }
        }

        public Dictionary()
        {
            _key = new List<TKey>();
            _value = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
                if (_key.Contains(key))
                {
                    throw new Exception();
                }

                _key.Add(key);
                _value.Add(value);
           
        }

        public TValue GetByKey(TKey key)
        {

            if (!_key.Contains(key))
            {
                throw new KeyNotFoundException();
            }

            return _value[_key.IndexOf(key)];
        }

        public TKey GetByValue(TValue value)
        {
            if (!_value.Contains(value))
            {
                throw new KeyNotFoundException();
            }

            return _key[_value.IndexOf(value)];
        }

        public void RemoveByKey(TKey key)
        {
            if (!_key.Contains(key))
            {
                throw new KeyNotFoundException();
            }
                        
            _value.RemoveAt(_key.IndexOf(key));
            _key.RemoveAt(_key.IndexOf(key));
        }

        public void RemoveByValue(TValue value)
        {
            if (!_value.Contains(value))
            {
                throw new Exception();
            }

            _key.RemoveAt(_value.IndexOf(value));
            _value.RemoveAt(_value.IndexOf(value));
            
        }


    }
}
