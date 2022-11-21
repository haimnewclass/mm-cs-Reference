using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{

    class A:Object {
        public void GetA() { }
    }
    class B:A {
        public void GetB() { }
    }
    class C:B {
        public void GetC() { }
    }


    internal class Week8_1_Object
    {
        public static void Run()
        {
            B b = new B();
            A a = b;



            object o = new object();
            a.GetA();
            o = a;
           





            int i = 90;

            System.IO.FileInfo f = null;

            object[] list = new object[100];
            list[0] = b;
            list[1] = a;
            list[2] = o;
            list[3] = f;
            list[4] = i;

          
            if (list[0] is B)
            {
                B b1 = (B)list[0];
            }
            if (list[4] is int)
            {
                int g = (int)list[4];
                g++;
                list[4] = g;
            }

            
        }
    }
}
