using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week8_5_BasePointer
    {
        public static void Run()
        {
            Ball a = new Ball();
            Toy b = new Toy();


            Item item = new Toy();

            a.Func2();
            item = a;
            item.Func1();

    
            item = a;
            item = b;

            Ball[] ballList = new Ball[10];
         //   Toy[] ballList = new Toy[10];
            Item[] List = new Item[100];

            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 100; i++)
            {
                if(random.Next(1,2)==1)
                {
                    // create Ball
                    List[i] = new Ball();
                }
                else
                {
                    // create Toy
                    List[i] = new Toy();
                }
            }
            
        }
        class Ball:Item {
            public void Func2() { }
        }
        class Toy:Item {
            public void Func3() { }
        }

        class Item {
            public void Func1() { }
        }
    }

    
}
