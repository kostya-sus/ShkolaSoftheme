using ProtoBuf;
using System.IO;
using System.Collections.Generic;


namespace HW18_Mobile
{
    public class ProtoBufSerialization<T> 
    {
        

        public void Serialize(List<T> list)
        {
            using (var file = File.Create("protoBuf.bin"))
            {
                Serializer.Serialize(file, list);
            }
        }

        public List<T> Deserialize()
        {
            using (var file = File.OpenRead("protoBuf.bin"))
            {
                return Serializer.Deserialize<List<T>>(file);
            }
        }
    }
}
