using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference.Events
{
    public class Week16_1_Event
    {
        public void Run()
        {
            MathAction func = this.Minus;
            int g = func(100, 100);
            func = this.Plus;
            g = func(100, 100);

            AA a1 = new AA();
            AA a2 = new AA();
            BB a3 = new BB();

            RunEvent();

        }

        static public event MathAction broadcast;

        public delegate int MathAction(int num1, int num2);

        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Plus(int a,int b)
        {
            return a + b;
        }

        public void RunEvent()
        {
            broadcast(30, 40);
            broadcast(300, 400);
        }

    }

    public class AA
    {
        public AA()
        {
            Week16_1_Event.broadcast += this.Run;
        }

        

        public int Run(int a,int b)
        {
            return 0;
        }
    }


    public class BB
    {
        public BB()
        {
            Week16_1_Event.broadcast += this.Run;
        }

        public int Run(int a, int b)
        {
            return 0;
        }
    }



}
