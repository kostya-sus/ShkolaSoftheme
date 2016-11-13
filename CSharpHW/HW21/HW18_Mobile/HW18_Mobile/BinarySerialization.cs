using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace HW18_Mobile
{
    public class BinarySerialization<T> 
    {
        private const string FileName = "binarySerializer.zip";
        public void Serialize(List<T> list)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("binary.zip", FileMode.Create))
            {
                formatter.Serialize(fs, list);
            }
        }

        public List<T> Deserialize()
        {
            BinaryFormatter bFormatter = new BinaryFormatter();

            using (FileStream fStream = new FileStream("binary.dat", FileMode.Open))
            {
                return (List<T>)bFormatter.Deserialize(fStream);
            }
        }
    }
}
