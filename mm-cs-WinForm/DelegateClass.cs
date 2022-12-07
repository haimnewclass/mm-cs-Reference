using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_WinForm
{
    internal class DelegateClass
    {
        private DelegateClass() { }
        private static readonly DelegateClass _instance = new DelegateClass();
 

        public static DelegateClass Instance
        {
            get { return _instance; }
           
        }

        public delegate int T2numbers(int a, int b);

        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Calc(int a, int b, T2numbers func)
        {
            T2numbers funcPlus = Plus;
            //   func(a,b) + 10;
            return funcPlus(func(a,b), 10);
        }
    }
}
