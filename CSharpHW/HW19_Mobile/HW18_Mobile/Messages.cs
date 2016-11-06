using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18_Mobile
{
    public class Messages
    {
        public MobileAccount From { get; private set; }
        public MobileAccount ForWhom { get; private set; }
       
                
        public Messages(MobileAccount from, MobileAccount forWhom)
        {
            From = from;
            ForWhom = forWhom;
        }
    }
}
