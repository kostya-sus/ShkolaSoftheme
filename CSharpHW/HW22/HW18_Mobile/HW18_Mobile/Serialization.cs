using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace HW18_Mobile
{
    class Serialization
    {
        public static void SerializationCompare()
        {

            BinarySerialization<MobileAccount> binarySerialization = new BinarySerialization<MobileAccount>();
            XmlSerialization<MobileAccount> xmlSerialization = new XmlSerialization<MobileAccount>();
           
            MobileOperator mOperator3 = new MobileOperator("098", "Kievstar");
            MobileOperator mOperator4 = new MobileOperator("093", "Life");
            MobileAccount account1 = new MobileAccount(mOperator3);
            MobileAccount account2 = new MobileAccount(mOperator4);
            MobileAccount account3 = new MobileAccount(mOperator3);
            MobileAccount account4 = new MobileAccount(mOperator4);


            account1.AddContact(account2.Name, account2);
            account2.AddContact(account1.Name, account1);
            account1.AddContact(account3.Name, account3);
            account2.AddContact(account4.Name, account4);

            List<MobileAccount> testList = new List<MobileAccount>();
                        
              for (int i = 0; i < 5; i++)
              {
                  testList.Add(account1);
                  testList.Add(account2);

              }
              
          
            
            
            binarySerialization.Serialize(testList);
            xmlSerialization.Serialize(testList);
            var des = binarySerialization.Deserialize();
            
                                

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("xml.xml");
        
            XmlElement xRoot = xDoc.DocumentElement;
            
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                     foreach (XmlNode node in childnode.ChildNodes)
                        {
                                                 
                        if (node.Name == "Contact")
                        {
                            foreach (XmlNode last in node.ChildNodes) 
                            {

                                if (last.Name == "Name")
                                {
                                    Console.WriteLine("     Name of Contact: {0}", last.InnerText);
                                }
                                if (last.Name == "AccountName")
                                {
                                    Console.WriteLine("     AccountName of Contact : {0}", last.InnerText);
                                }
                                
                            }
                           
                        }
                    }
                    

                    if (childnode.Name == "Name")
                    {
                        Console.WriteLine("Name: {0}", childnode.InnerText);
                    }
                  
                    if (childnode.Name == "Number")
                    {
                        Console.WriteLine("Number: {0}", childnode.InnerText);
                    }
                    

                }
                Console.WriteLine();
            }
            Console.Read();





        }
        
    }
}
