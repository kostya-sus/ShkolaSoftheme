using System;

using System.IO;

using System.Text;

namespace HW9_FileHandle
{
    class Program
    {
        static void Main(string[] args)
        {
          
                string filePath = null ;
                FileHandle fileHandel = new FileHandle();




                Console.WriteLine("Enter path ");
                try
                {
                    filePath = Console.ReadLine();

                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }



                try
                {
                    fileHandel = OpenForRead(filePath);

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(fileHandel);
                Console.ReadKey();
            }

        public static FileHandle OpenForRead(string filePath)
        {
            FileInfo file = new FileInfo(filePath);


            FileStream fileStream = File.OpenRead(filePath);
            byte[] byteA = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);

            while (fileStream.Read(byteA, 0, byteA.Length) > 0)
            {
                Console.WriteLine(temp.GetString(byteA));
            }


            return new FileHandle(file.Length, file.Name, file.FullName, FileAccessEnum.Read);
           

        }

        public FileHandle OpenForWrite(string filePath)
        {
            FileInfo file = new FileInfo(filePath);


            return new FileHandle(file.Length, file.Name, file.FullName, FileAccessEnum.Write);
        }

        public void OpenFile(FileHandle fileHandel)
        {
            fileHandel.FileAccessEnum = FileAccessEnum.ReadWrite;
        }
    
    }
}
