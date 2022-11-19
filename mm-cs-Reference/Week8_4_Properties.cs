using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week8_4_Properties
    {
        public void RunProperty()
        {
            Car car1 = new Car();
            car1.Firm = "SubaroLegacy";
            Console.WriteLine(car1.Firm);

            car1.Firm = "ffff";
            car1.Firm = car1.Firm + "New ";
            car1.Firm = car1.Firm + "New ";
            car1.Firm = car1.Firm + "New ";
            car1.Firm = car1.Firm + "New ";
            car1.Firm = car1.Firm + "New ";


            car1.KM = 10;
            car1.Id = 123344;

            car1.KM += 30;
            car1.KM += 100;

            car1.KM -= 45;
            car1.KM = -349;

          //  car1.Firm = "Mitsubishi";
          //  car1.Firm = "Susita";
          //  car1.Firm = "Mercedes";

            Car car2 = new Car();
            car2.Firm = "Mazda";
            car2.Id = 67545;
        }
    }

    class Car
    {
        public Car() { }

        public int MyProperty { get; set; }
       
        public int KM;
        public int Id { get; set; }

        private int changedName=0; 
        private string _Firm;
        public string Firm
        {
            
            get { 

                return "The Best car : "+_Firm;
            }
            set
            {
                if (value == "*")

                    changedName = 0;

                if (changedName < 3)
                {
                    _Firm = value;
                    changedName++;
                }
            }
        }


    }

}
