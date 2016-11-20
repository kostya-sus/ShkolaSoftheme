using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace HW25_Multithreading_UnZip
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = false;
            string link = null;
            while (!check)
            {
                Console.WriteLine("Please enter correct path do directory");
                link = Console.ReadLine();
                check = Directory.Exists(link);

            }
            
            var allfiles = Directory.GetFiles(link, ".", SearchOption.AllDirectories);

            var threadsList = new List<Thread>();

            foreach (var a in allfiles)
            {
                Console.WriteLine(a);
                Thread archieverThread = new Thread(() => ZipFiles.UnZip(a));
                threadsList.Add(archieverThread);
            }

            foreach (Thread thread in threadsList)
            {
                thread.Start();
            }

            foreach (Thread thread in threadsList)
            {
                thread.Join();
            }
            
            Console.ReadLine();
        }
    }
}
