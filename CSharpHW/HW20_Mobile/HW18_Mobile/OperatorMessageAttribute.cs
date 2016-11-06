using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW18_Mobile
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OperatorMessageAttribute : Attribute
    {
        public Level Level { get; set; }

        public OperatorMessageAttribute(Level level)
        {
            Level = level;
        }

        public static Level GetAttributeInfo(MethodBase method)
        {
            OperatorMessageAttribute attribute = (OperatorMessageAttribute)method
                                                 .GetCustomAttribute(typeof(OperatorMessageAttribute), true);

            return attribute.Level;
        }
    }
}
