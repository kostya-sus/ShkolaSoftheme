using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using System.Linq;



namespace HW_26TPL
{
    internal class Replacer
    {
        public void Replace(string path, string oldValue, string newValue, string extension)
        {
            var logsListConcurrentQueue = new ConcurrentQueue<string>();
            var filesList = new List<string>();
            var logStatus = true;
            string info;


            var logThread = new Thread(start:() =>{
                                             using (var fileLog = new StreamWriter(Directory.GetCurrentDirectory() + "//log_file.txt", true))
                                                {
                                                 while (logStatus)
                                                       while (logsListConcurrentQueue.TryDequeue(out info))
                                                              fileLog.WriteLine(info);
                                                }
                                            });

            var allFiles = Directory.GetFiles(path, ".", SearchOption.AllDirectories);
            filesList.AddRange(allFiles.Where(file => extension == "*" || Path.GetExtension(file) == "." + extension));

            logThread.Start();
            Parallel.ForEach(filesList, (replaceFile) =>{
                                                           try
                                                           {
                                                               var lines = File.ReadAllLines(replaceFile);
                                                               var replaceLines = new string[lines.Length];

                                                               for (var i = lines.Length - 1; i >= 0; --i)
                                                               {
                                                                   replaceLines[i] = lines[i].Replace(oldValue, newValue);
                                                                   if (replaceLines[i] != lines[i])
                                                                        logsListConcurrentQueue.Enqueue($"||{DateTime.Now}|| FILE NAME||{replaceFile}||\n NUMBER OF LINE||{i}||" +
                                                                                                       $"\n ORIGIN LINE   ||{lines[i]}||\n CHANGED LINE  ||{replaceLines[i]}||");
                                                               }
                                                               File.WriteAllLines(replaceFile, replaceLines);
                                                           }
                                                           catch (Exception exception)
                                                           {
                                                               logsListConcurrentQueue.Enqueue($"{DateTime.Now}: Exception |{exception.Message}|");
                                                           }
                                                       });
            logStatus = false;
            logThread.Join();
        }
    }
}
