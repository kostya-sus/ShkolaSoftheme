using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {

           
            ShapeDescriptor Shape = new ShapeDescriptor(new Point(1, 1), new Point(1, 1));
            ShapeDescriptor Shape2 = new ShapeDescriptor(new Point(1, 1), new Point(1, 1), new Point(1, 1));
            ShapeDescriptor Shape3 = new ShapeDescriptor(new Point(1, 1), new Point(1, 1), new Point(1, 1), new Point(1, 1));

            Console.WriteLine("This shape is {0}", Shape.ShapeType);
            Console.WriteLine("This shape is {0}", Shape2.ShapeType);
            Console.WriteLine("This shape is {0}", Shape3.ShapeType);

            Console.ReadKey();

        }
    }
}
