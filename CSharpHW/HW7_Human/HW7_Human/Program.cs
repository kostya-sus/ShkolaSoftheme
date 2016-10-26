using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Human
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1993,12,26);
            Human human = new Human("firstName", "lastName");
            Human humanClone = new Human("firstName", "lastName");
            Human humanClone2 = new Human("firstName", "lastName");
            Human humanClone3 = new Human("firstName", "lastName", birthdate);


            Console.WriteLine(human.Equals(humanClone));
            Console.WriteLine(humanClone3.Age);

            Console.ReadKey();
        }
    }
}
