using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_CarConstructor
{
    class CarConstructor
    {

        public Transmission Transmission { get; set; }
        public Color Color { get; set; }
        public Engine Engine { get; set; }

       
        public Car CarConstruct(Engine engine, Color color, Transmission transmission)
        {
            Car newCar = new Car();
            newCar.Color = color;
            newCar.Transmission = transmission;
            newCar.Engine = engine;


            return newCar;
        }

        public Car Reconstruct(Car car)
        {
            var type = "NEW_ENGINE";
           
            car.Engine = new Engine(type);

            return car;
        }
        


    }
}
