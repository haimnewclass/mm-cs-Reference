using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{

    class Dr :student
    {

        public Dr(int ID):base(ID) 
        {
         
        }

        public Dr(int ID, string NAME):base(ID,NAME)
        {
             
        }
        public string PrintDR()
        {
            string ret = name + " " + age.ToString()+" "+BusMoney.ToString();
            return ret;
        }

        public bool Research;

    }
    class student{

        public student(int ID)
        {
            id = ID;
        }

        public student(int ID,string NAME)
        {
            this.id = ID;
            this.name = NAME;
        }
        protected int BusMoney;

        public int age;
        public int id;
        public string name;

        public void SetAge(int age)
        {
            this.age = age;
        }
        public string PrintDetails()
        {
            string ret;

            ret = "The details "+name +" "+ age.ToString()+" "+ id.ToString();

            return ret;
        }

    }





    class Week8_7_ClassParty
    {
        public void Run()
        {
            student s = new student(122);
            s.age = 22;
    //        s.id = 122222;
            s.name = "Sami";

            Dr d = new Dr(12, "Kalman");
         
            student s8 = d;
         
            student p = new student(33,"Rina");
            p.age = 33;
            if(p is student)
            {

            }
            //p.id = 2434534;
            //  p.name = "Rina";

            int a = 9;
            int b = a;



            Console.WriteLine(s.PrintDetails());
            Console.WriteLine(p.PrintDetails());
        }
    }
}
