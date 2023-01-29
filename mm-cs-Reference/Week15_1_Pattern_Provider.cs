using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference.Design
{
    public interface ILogger
    {
        void Init();
        void LogEvent(string msg);
        void LogError(string msg);
        void LogException(string msg,Exception exce);
        void LogCheckHoseKeeping();
    }

    internal class Week15_1_Pattern_Provider
    {
        public class Logger
        {
            static ILogger myLog;
            public static void LogEvent(string msg)
            {
                myLog.LogEvent(msg);
            }
            public static void LogException(string msg)
            {
                myLog.LogException(msg,null);
            }
        }

        public enum providerType
        { 
            car,
            korkinet,
            none
        }

        public IMotion CurrMotion { get; set; }
        public IMotion Run(providerType aProvider)
        {
            if (aProvider == providerType.car)
            {
                // Car
                CurrMotion = new Car();
            }
            else if(aProvider == providerType.korkinet)
            {
                // Korkinet
                CurrMotion = new Korkinet();
            }
            else
            {
                //None
                CurrMotion = new None();
            }

            return CurrMotion;
        }
    }
    //Design Pattern :Provider
    public interface IMotion
    {
        void F(int km);
        void B(int km);
        int GetKm();
        void Init();
    }

    class Car : IMotion
    {
        public void OpenWindows()
        {

        }

        public void OpenRadio()
        {

        }
        private int Km;
        public void F(int km)
        {
            Km += km;

        }
        public void B(int km)
        {
            Km -= km;
        }
        public int GetKm()
        {
            return Km;
        }
        public void  Init()
        {
            Km= 0;
        }
    }

    class None : IMotion
    {
        private int Km;
        public void F(int km)
        {
            

        }
        public void B(int km)
        {
            
        }
        public int GetKm()
        {
            return Km;
        }
        public void Init()
        {
            Km = 0;
        }
    }

    class Korkinet : IMotion
    {
        private int Km;
        public void F(int km)
        {
            Km += km - 1;

        }
        public void B(int km)
        {
            Km -= km;
        }
        public int GetKm()
        {
            return Km;
        }
        public void Init()
        {
            Km = 0;
        }

        public void ChargePower()
        {

        }
    }


}
