using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HW18_Mobile
{
    public class XmlSerialization<T> 
    {
      

        public void Serialize(List<T> list)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream("xml.xml", FileMode.Create))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }

        public List<T> Deserialize()
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream("xml.xml", FileMode.Open))
            {
                return (List<T>)xmlFormatter.Deserialize(fs);
            }
        }
    }
}
