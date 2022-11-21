using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference.Patterns
{
    internal class Week9_2_Singletone
    {
        public void Run()
        {
            aaa a1 = aaa.CreateKuku();
            aaa a2 = aaa.CreateKuku();
            aaa a3 = aaa.CreateKuku();

            bbb.INSTANCE.Name = "Miriam";
            bbb.INSTANCE.Age = 23;
            bbb.INSTANCE.SetValues(33, "Miriam");
           
        }
    }
    public class bbb    
    {
        private bbb() {
        
        }
        private static bbb _INSTANCE = new bbb();
        public static  bbb INSTANCE
        {
            get {
                return _INSTANCE; 
            }
        }
        public int GetNum()
        {
            return 1;
        }

        public void SetValues(int age,string name)
        {
            Name = name;
            Age = age;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }

    public class aaa
    {
        public static aaa CreateKuku()
        {
            // conditions 
            return new aaa();
        }
        private aaa()
        {

        }
    }



}
