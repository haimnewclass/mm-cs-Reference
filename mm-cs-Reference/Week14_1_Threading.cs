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
            Count c1 = new Count("A");
            Count c2 = new Count("B");            
        }

    }

    class Count 
    {
        public Count(string label)
        {
            Label = label;
            thread = new Thread(Run);
            thread.Start();
        }

        public string Label { get; set; }

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" This is num {i} {Label}  ");
                System.Threading.Thread.Sleep(1000);
            }
        }

        Thread thread;
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
