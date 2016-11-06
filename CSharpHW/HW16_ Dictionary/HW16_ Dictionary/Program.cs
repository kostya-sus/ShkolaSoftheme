using System;


namespace HW16__Dictionary
{
    class Program
    {
        private const int KeyCount = 10;
        private static string[] _Values = { "Number0", "Number1", "Number2",
                                                   "Number3", "Number4", "Number5",
                                                   "Number6", "Number7", "Number8",
                                                   "Number9" };

        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary<TKey,TValue>");
            var myDictionary = new Dictionary<int, string>();

            Console.WriteLine("Add value to dictionary:");
            for (int i = 0; i < KeyCount; i++)
            {
                Console.WriteLine("Key = {0}, Value = {1}.", i, _Values[i]);
                myDictionary.Add(i, _Values[i]);
            }

            Console.WriteLine("Lets get values by key ");
            GetByKeyDictionary(myDictionary, 8);
            GetByKeyDictionary(myDictionary, 40);

            Console.WriteLine("Lets get key by values ");
            GetByValueDictionary(myDictionary, "Number8");
            GetByValueDictionary(myDictionary, "Number15");
                       
            Console.WriteLine("If key is exists");
            AddToDictionary(myDictionary, 4, _Values[2]);
            AddToDictionary(myDictionary, 5, _Values[2]);
            AddToDictionary(myDictionary, 10, _Values[2]);

            Console.WriteLine("Delete some value by keys ");
            RemoveByKeyDictionary(myDictionary, 6);
            RemoveByKeyDictionary(myDictionary, 40);

            Console.WriteLine("Delete some value by value ");
            RemoveByValueDictionary(myDictionary, "Number8");
            RemoveByValueDictionary(myDictionary, "Number20");

            Console.ReadLine();
        }

        static void GetByKeyDictionary(Dictionary<int, string> targetDictionary, int key)
        {
            try
            {
                Console.WriteLine(targetDictionary.GetByKey(key));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void GetByValueDictionary(Dictionary<int, string> targetDictionary, string value)
        {
            try
            {
                Console.WriteLine(targetDictionary.GetByValue(value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void RemoveByKeyDictionary(Dictionary<int, string> targetDictionary, int key)
        {
            try
            {
                targetDictionary.RemoveByKey(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void RemoveByValueDictionary(Dictionary<int, string> targetDictionary, string value)
        {
            try
            {
                targetDictionary.RemoveByValue(value);
            }
            catch (Exception)
            {
                Console.WriteLine("Value not exist");
            }

        }

        static void AddToDictionary(Dictionary<int, string> targetDictionary, int key,string value)
        {
            try
            {
                targetDictionary.Add(key, value);
            }
            catch (Exception)
            {
                Console.WriteLine("Key already exists. Use another");
            }

        }


    }
}
