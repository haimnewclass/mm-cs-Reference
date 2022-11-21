using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Week9_2_DirectData
    {
        Citizen[] list = new Citizen[999999999];

        Citizen[] students = new Citizen[999999999];
        public Citizen GetStudentById(int id)
        {
            return students[id];
        }


        // Blue
        // Green
        // Black
        // Purple
        // Yellow
       /* int arr[] = new int[3000];
        public int GetIndexByName(string name)
        {
            
            char c = name[0];
            int ret = (int)c;
            return ret;
        }
       */

        // hash function
        public int GetIndexByID(int id)
        {
            return int.Parse(id.ToString().Substring(4, 9));
        }
        public void Run()
        {
            Citizen citizen  = GetStudentById(31652436);
            citizen = GetStudentById(31699999);


        }
    }
}
