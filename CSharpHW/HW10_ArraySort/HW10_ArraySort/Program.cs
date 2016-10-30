using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];

            Random random = new Random();
            // заполняем массив
            for (int i = 0; i < size; i++)
            {
                a[i] = random.Next(0, size);
            }
            // Выводим массив
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            //выполнение сортировки
            for (int i = 0; i < size; i++)
            {
                int temp = a[i]; 
                int j = i - 1;
                while (j >= 0 && a[j] > temp)
                
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = temp;
                 
            }
            Console.WriteLine("\nSort array\n");
            // Выводим отсортированный массив
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            Console.ReadKey();
           
        }
    }
}
