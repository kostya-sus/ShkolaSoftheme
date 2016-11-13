using ProtoBuf;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace HW18_Mobile
{

    [Serializable]
    [DataContract]
    [ProtoContract]
    public class Contact
    {
        [DataMember]
        [ProtoMember(1)]
        public string Name { get; set; }
        [DataMember]
        [ProtoMember(2)]
        public string AccountName { get; set; }
        public Contact() {  }
      
    }
}
