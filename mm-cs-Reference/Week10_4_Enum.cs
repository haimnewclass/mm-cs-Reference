using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week10_4_Enum
    {
        // Enumeration
        int age;

        string days="kuku";

        public enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public WorkDays work;
        public static void Run()
        {
            int id;
            WorkDays b,a;

            a = WorkDays.Sunday;
            b = WorkDays.Friday;
            WorkDays c = a;
            c = WorkDays.Tuesday;

            string SaveToFile;
            // convert Enum to String
            SaveToFile = b.ToString();
            a++;

            // convert String to Enum
            WorkDays r;
            r = (WorkDays) Enum.Parse(typeof(WorkDays), "kuku");
            a = r;

        }

    }
}
