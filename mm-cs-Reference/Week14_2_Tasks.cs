using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week14_2_Tasks
    {
        public bool Running = true;
        public object obj = new object();
        public void RunThread()
        {

            // OpenFile to write
            for (int i = 0; i < 10 || Running; i++)
            {
                // Critical Section
                lock(obj)
                {
                    System.IO.File.WriteAllText(@"c:\a\log.txt", $"{i} {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                }
                
                Console.WriteLine($"{i}");
                System.Threading.Thread.Sleep(1000*60*60);
                // Get from user . Set Running = false
            }
        }

        public void Run()
        {
            Task.Run(RunThread);
            Task.Run(RunThread);
            Task.Run(RunThread);
            Task.Run(RunThread);
            Task.Run(RunThread);
            Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {

                }
            });
        }
    }
}
