using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{

    public interface IMove
    {
        int Go(int km);
    }
    public class Car3 : Bycle, IMove {
        public int Go(int km)
        {
            return km*100;
        }
        public void OpenWindo()
        {

        }
    }
    public class Bycle : IMove
    {
        public int Go(int km)
        {
            return km * 2;
        }

        public void MakeDingDing()
        {

        }
    }

    public class MyClass:IMove
    {
        public int Go(int km)
        {
            return km * 2;
        }
    }

    public class Week10_4_Interfaces
    {
        public static void Run()
        {
            IMove mo = new MyClass();
            mo.Go(45);
            
            Car3 car3 = new Car3();
            Bycle bycle = new Bycle();

            car3.OpenWindo();
            mo = car3;
            mo.Go(34);
            mo = bycle;

            DoWork(car3);
            DoWork(mo);
            DoWork(bycle);
        }

        public static void DoWork(IMove m)
        {
            m.Go(100);
            // Immposible to call other methods
            //m.OpenWindow();
        }
    }
}
