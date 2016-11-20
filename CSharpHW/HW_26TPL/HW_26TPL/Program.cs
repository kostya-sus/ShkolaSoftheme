using System;
using System.IO;

namespace HW_26TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var check = false;
            var stringReplacer = new Replacer();
            
            string link = null;
            while (!check)
            {
                Console.WriteLine("Please enter correct path do directory");
                link = Console.ReadLine();
                check = Directory.Exists(link);

            }

           Console.WriteLine("Please enter extension of file (for all files enter *)");
           var extension = Console.ReadLine();
            


            stringReplacer.Replace(link, "SELECT", "var", ".sql");
            stringReplacer.Replace(link, "SELECT", "var", extension);

            Console.WriteLine("Press anykey to exit");
            Console.ReadKey();


        }
    }
}
