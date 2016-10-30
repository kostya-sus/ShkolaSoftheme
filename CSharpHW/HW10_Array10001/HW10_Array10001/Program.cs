using System;

using System.Linq;


namespace HW10_Array10001
{
    class Program
    {
          static void Main(string[] args)
            {
                var arr = FillArray();
                var a = UniqueElement(arr);
               
                int index = Array.IndexOf(arr, a);
                Console.WriteLine("In the array element is not repeated number [{0}]={1}", index, a);
                Console.ReadKey();
            }

            private static int UniqueElement(int[] arr)
            {
                var a = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                a ^= arr[i];               
                }
          
            return a;
            }

            private static int[] FillArray()
            {
                var fillArray = new int[10001];
                int half = 10001 / 2;

                for (int i = 0; i < half; i++)
                {
                     fillArray[i] = i;
                }

                for (int i = 0; i < half + 1; i++)
                {
                     fillArray[half + i] = i;
                }
           
                return fillArray;
            }
       
    }
}
