using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_CarConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var transmissionType = "standart";
            var carColor = "white";
            var engineType = "standart";

            Transmission transmission = new Transmission(transmissionType);
            Color color = new Color(carColor);
            Engine engine = new Engine(engineType);

            CarConstructor carModel = new CarConstructor();
            Car car = carModel.CarConstruct(engine, color, transmission);
            Console.WriteLine("Color="+car.Color.ColorType);
            Console.WriteLine("Engine="+car.Engine.Type);
            Console.WriteLine("Transmission="+car.Transmission.TransmissionType);
            Console.WriteLine();
            carModel.Reconstruct(car);
            Console.WriteLine("Color=" + car.Color.ColorType);
            Console.WriteLine("Engine=" + car.Engine.Type);
            Console.WriteLine("Transmission=" + car.Transmission.TransmissionType);
            Console.ReadKey();

        }

    } 
}
