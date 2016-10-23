using System;
using System.Linq;



namespace HW5_ConsoleFigures
{
    class Program
    {

        static void Main(string[] args)
        {
                Console.WriteLine("Enter size of each figure : ");
                Console.WriteLine("Triangle: ");
                string inputTriangle = Console.ReadLine();
                Console.WriteLine("Square: ");
                string inputSquare = Console.ReadLine();
                Console.WriteLine("Romb: ");
                string inputRomb = Console.ReadLine();
           
           
            PrintTriangle(int.Parse(inputTriangle));
            PrintSquare(int.Parse(inputSquare));
            PrintRomb(int.Parse(inputRomb));

            Console.ReadLine();
        }

      

        static void PrintTriangle (int size)
        {
            Console.WriteLine("1. Triangle\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        static void PrintSquare(int size)
        {
            Console.WriteLine("2. Square/n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintRomb(int size)
        {
            Console.WriteLine("3. Romb\n");

            int input = size - 1, stars = 1;
            //first part of romb
            for (int i = 0; i < size; i++)
            {
                int j = input;
                while (j != 0)
                {
                    Console.Write(" ");
                    j--;
                }

                j = stars;
                while (j != 0)
                {
                    Console.Write("*");
                    j--;
                }

                input--;
                stars += 2;

                Console.WriteLine("");
            }

            input++;
            stars-= 2;
            //second part of romb
            for (int i = 0; i < size - 1; i++)
             {
                 input++;
                 stars -= 2;

                 int j = input;
                 while (j != 0)
                 {
                     Console.Write(" ");
                     j--;
                 }

                 j = stars;
                 while (j != 0)
                 {
                     Console.Write("*");
                     j--;
                 }
                 Console.WriteLine("");
             }
        }
    }
}