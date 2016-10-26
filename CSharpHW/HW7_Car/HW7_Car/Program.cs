using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Model = "Tesla", Color = "Green", Year = 2016 };
            Car car2 = new Car() { Model = "Tesla", Color = "Green", Year = 2016 };
            TuningAtelier.TuneCar(car);
          
            Console.WriteLine(car2.Color);
            Console.WriteLine(car.Color);

            Console.ReadKey();
        }
    }
}
