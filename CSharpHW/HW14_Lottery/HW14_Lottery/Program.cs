using System;

using System.Text.RegularExpressions;

namespace HW14_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            const string symbol = @"^(( )*[1-9]){6}$";
            string input;

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            if (name == String.Empty)
            {
                name = "NoNamePlayer";
            }



            var generator = new Generator();
            generator.Generate();
            var a = true;

            do
            {

                Console.Write("{0} try to guess ticket number! Enter 6 numbers in a range 1-9(in format 'xxxxxx'): ", name);
                input = Console.ReadLine();
                var regex = new Regex(symbol);


                if (regex.IsMatch(input))
                {
                    if (generator.ticket == input)
                    {
                        Console.WriteLine("Congratulations, you win");
                        a = true;
                    }
                    else
                    {
                        Console.WriteLine("You lose. The combination was {0}.", generator.ticket);
                        a = true;
                    }
                }
                else
                {
                    Console.Write("Wrong input format!");
                    a = false;
                }

                Console.ReadKey();
                Console.Clear();
            } while (!a);
        }


       
    
        
    }
}
