using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week14_1_Threading
    {
        public void Run()
        {
            Count c1 = new Count();
            Count c2 = new Count();

            c1.Run();
            c2.Run();
        }

    }

    class Count 
    {
         
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" This is num {i} ");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class Mythread
    {
        public void RunProg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" This is num {i} ");
                Thread.Sleep(500);                
            }

        }

        Thread thread;
        public Mythread()
        {
            thread = new Thread(RunProg);
            thread.Start();
        }


    }






}
