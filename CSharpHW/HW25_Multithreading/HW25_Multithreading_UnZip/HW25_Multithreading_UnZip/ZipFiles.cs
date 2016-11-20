using System;
using System.IO.Compression;
using System.IO;


namespace HW25_Multithreading_UnZip
{
    class ZipFiles
    {
        public static void Zip(string name)
        {
            try
            {
                var temp = name.Replace(Path.GetFileName(name), Path.GetFileNameWithoutExtension(name));
                Directory.CreateDirectory(temp);
                File.Copy(name, temp + "\\" + Path.GetFileName(name));
                if (!File.Exists(temp + ".zip"))
                {
                    ZipFile.CreateFromDirectory(temp, temp + ".zip");
                }
                Directory.Delete(temp, true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static void UnZip(string name)
        {
            try
            {
                var passExt = Path.GetDirectoryName(name) + "\\EXtract";
                if (Path.GetExtension(name) == ".zip")
                {
                    ZipFile.ExtractToDirectory(name, passExt);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
