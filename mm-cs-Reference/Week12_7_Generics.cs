using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices;

namespace mm_cs_Reference.Generics
{
    internal class Week12_7_Generics
    {
        public static void Run()
        {
             
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Hashtable hashtable= new Hashtable();
           
            hashtable.Add(123, new Item());
            hashtable.Add(567, car2);
            hashtable.Add(987, car3);
            car2 = (Car) hashtable[123];

            Week12_7_Generics o = new Week12_7_Generics();

            o.Go<int>(123);
            o.Go<string>("qewer");
            o.Go<bool>(true);

            o.Plus<int>(1, 2);
            o.Plus<string>("aaa", "bbb");

            System.Collections.Generic.Queue<Car> q = new Queue<Car>();
            q.Enqueue(new Car());

            System.Collections.Generic.Dictionary<int,Car> dictionary = new System.Collections.Generic.Dictionary<int,Car>();
            dictionary.Add(123, new Car());

            SortedList<string, Item> list = new SortedList<string, Item>();
            list.Add("cola", new Item());

        }

        public T Plus<T>(T a, T b)
        {
            return a;
        }

        public void Go<E>(E a)
        {
            E b;
            b = a;
            Console.WriteLine(a);

            Bank<Car> bank = new Bank<Car>();
            Bank<string> bank1 = new Bank<string>();
        }
    }


    public class Bank<T>
    {
        private T data;
        public void Run(T a)
        {
            if(a.GetType()==typeof(Car))
            {

            }else if (a.GetType() == typeof(Item))
            {

            }
            else if (a.GetType() == typeof(int))
            {

            }
    
        }
    }

    public class Car:Object
    {

    }

    public class Item
    {

    }
    public class MyHash
    { 
        
    }


}
