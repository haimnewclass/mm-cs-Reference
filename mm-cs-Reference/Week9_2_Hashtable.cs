using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace mm_cs_Reference.Hash
{
    class Student {
        public Student(int id)
        {
            Id = id;
        }
        public  int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Week9_2_Hashtable
    {
        Hashtable tbl = new Hashtable();
        public void Run()
        {
            Student s1 = new Student(123);
            Student s2 = new Student(356456456);
            Student s3 = new Student(987);
            tbl.Add(s1.Id, s1);
            tbl.Add(s2.Id, s2);
            tbl.Add(s3.Id, s3);

            Student s = (Student) tbl[356456456];
          //  s.Name;
           // s2.Name;
            ((Student)tbl[356456456]).Name= "A";

            tbl.Add("yaacov", 1234567);
            
            object o = tbl["yaacov"];
            int num = (int)o;

            if(tbl[356456456]is Student)
            {
                Student s10 = (Student) tbl[356456456];
                
            }

            tbl[4564444] = new Student(4564444); // tbl.Add(4564444,s7)
           // ((Student)tbl[4564444]).Name;

           


        }
    }
}
