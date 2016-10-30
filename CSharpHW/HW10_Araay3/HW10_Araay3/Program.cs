using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_Araay3
{
    class Program
    {

        static void Main(string[] args)
        {
            var arrInt = new int[] { 1, 2, 3 , 5 , 6 };

            ArrayExtension arrayInt = new ArrayExtension(arrInt);

            arrayInt.Add(4);
            arrayInt.Add(8);


            Console.WriteLine(arrayInt.Contains(8));
            Console.WriteLine(arrayInt.Contains(10));

            try
            {
                var a = arrayInt.GetByIndex(84);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }





           
            Console.ReadKey();

        }

    }
}
