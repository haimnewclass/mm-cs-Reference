using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week14_4_IEnumerable
    {
        public void Run()
        {
            
            MyList list = new MyList();
            list.Add(100);
            list.Add(2345);
            list.Add(33);
            list.Add(2);
            list.Add(22);
            list.Add(4444);

            foreach (int item in list)
            {
                Console.WriteLine( item);
            }

            list.Add(2);
            list.Add(22);
            list.Add(4444);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyEnumerator : IEnumerator
    {
        int[] arr = new int[100];
        int idx = 0;
        public void Add(int s)
        {
            arr[idx] = s;
            idx++;
        }
        public int GetId()
        {
            return 90;
        }
        int loop = -1;
        public object Current
        {

            get
            {
                return arr[loop];
            }
        }
        public bool MoveNext()
        {
            
            if(loop>=idx)
            {
                //Reset();
                return false;
            }
            else
            {
                loop++;
                if (arr[loop]==33)
                {
                    return MoveNext();
                }
                return true;
            }
           
        }

        public void Reset()
        {
            loop = -1;
        }
    }

    public class MyList: IEnumerable
    {
        MyEnumerator i = new MyEnumerator();
        public void Add(int a)
        {
            i.Add(a);
        }
        public IEnumerator GetEnumerator()
        {
            return i;
        }

    }

}
