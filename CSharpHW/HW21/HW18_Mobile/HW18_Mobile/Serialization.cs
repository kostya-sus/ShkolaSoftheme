using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HW18_Mobile
{
    class Serialization
    {
        public static void SerializationCompare()
        {
            BinarySerialization<MobileAccount> binarySerialization = new BinarySerialization<MobileAccount>();
            XmlSerialization<MobileAccount> xmlSerialization = new XmlSerialization<MobileAccount>();
            JsonSerialization<MobileAccount> jsonSerialization = new JsonSerialization<MobileAccount>();
            ProtoBufSerialization<MobileAccount> protoBufSerialization = new ProtoBufSerialization<MobileAccount>();

            MobileOperator mOperator3 = new MobileOperator("098", "Kievstar");
            MobileOperator mOperator4 = new MobileOperator("093", "Life");
            MobileAccount account1 = new MobileAccount(mOperator3);
            MobileAccount account2 = new MobileAccount(mOperator4);
           

            account1.AddContact(account2.Name, account2);
            account2.AddContact(account1.Name, account1);
          
            List<MobileAccount> testList = new List<MobileAccount>();
          
            for (int i = 0; i < 100000; i++)
            {
                testList.Add(account1);
                testList.Add(account2);
               
            }
            
            Console.WriteLine("Serialization");
            Stopwatch watchBinary = Stopwatch.StartNew();
            binarySerialization.Serialize(testList);
            watchBinary.Stop();
            Console.WriteLine("Binary: {0} ms", watchBinary.ElapsedMilliseconds);

            Stopwatch watchXml = Stopwatch.StartNew();
            xmlSerialization.Serialize(testList);
            watchXml.Stop();
            Console.WriteLine("XML: {0} ms", watchXml.ElapsedMilliseconds);

            Stopwatch watchJson = Stopwatch.StartNew();
            jsonSerialization.Serialize(testList);
            watchJson.Stop();
            Console.WriteLine("JSON: {0} ms", watchJson.ElapsedMilliseconds);

            Stopwatch watchProtoBuf = Stopwatch.StartNew();
            protoBufSerialization.Serialize(testList);
            watchProtoBuf.Stop();
            Console.WriteLine("Protobuf: {0} ms", watchProtoBuf.ElapsedMilliseconds);
            


        }
        
    }
}
