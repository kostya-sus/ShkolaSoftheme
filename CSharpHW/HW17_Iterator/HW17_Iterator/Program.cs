using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new ConcreteAggregate<int>();
            var strings = new ConcreteAggregate<string>();
            var numbersIterator = new ConcreteIterator<int>(numbers);
            var stringsIterator = new ConcreteIterator<string>(strings);
            
            var item = 5;

            for (int i = 0; i < item; i++)
            {
                numbers[i] = i;
                strings[i] = "Item" + i;
            }

            var NumberItem = numbersIterator.First();
            var StringItem = stringsIterator.First();

            Console.WriteLine("Int collection:\n");
            while (!numbersIterator.IsDone()) 
            {
                NumberItem = numbersIterator.Next();
                Console.WriteLine(NumberItem);
            }
            
            Console.WriteLine("String collection:\n");
            while (!stringsIterator.IsDone())
            {
                StringItem = stringsIterator.Next();
                Console.WriteLine(StringItem);
            }
        
            Console.ReadKey();
        }

   
      
    }
}
