using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    public class Week13_1_JSOM
    {
        static Dictionary<string, string> list = new Dictionary<string, string>();
        public static void Run()
        {
            list.Add("111", "fff");
            list.Add("222", "ert");
            list.Add("333", "ert");
            list.Add("444", "ert");
            list.Add("555", "ert");
            list.Add("666", "ertert");

            string s =  System.Text.Json.JsonSerializer.Serialize(list);

            Dictionary<string, string> list2 = new Dictionary<string, string>();

            list2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(s);

        }
    }
}
