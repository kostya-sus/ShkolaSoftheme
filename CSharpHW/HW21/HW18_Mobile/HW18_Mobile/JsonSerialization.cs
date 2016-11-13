using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace HW18_Mobile
{
    public class JsonSerialization<T> 
    {
     
        public void Serialize(List<T> list)
        {
            DataContractJsonSerializer jFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (FileStream fStream = new FileStream("json.json", FileMode.Create))
            {
                jFormatter.WriteObject(fStream, list);
            }
        }

        public List<T> Deserialize()
        {
            DataContractJsonSerializer jFormatter = new DataContractJsonSerializer(typeof(List<T>));
          
            using (FileStream fStream = new FileStream("json.json", FileMode.Open))
            {
                return (List<T>)jFormatter.ReadObject(fStream);
            }
        }
    }
}
