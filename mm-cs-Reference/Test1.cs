using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Item2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Test1
    {
        
        class aaa { public int Id { get; set; } }
        public void Ran()
        {
            Item[] arr = new Item[10];
            arr[0] = new Item() { Id = 1, Name = "Avi" };
            arr[1] = new Item() { Id = 2, Name = "Moshe Toiber" };
            arr[2] = new Item() { Id = 3, Name = "Meir" };
            arr[3] = new Item() { Id = 4, Name = "Tovi" };

            Item2[] arr2 = new Item2[10];
            arr2[0] = new Item2() { Id = 1, Name = "Avi ddd" };
            arr2[1] = new Item2() { Id = 2, Name = "Moshe ddd" };
            arr2[2] = new Item2() { Id = 3, Name = "Meir ddd" };
            arr2[3] = new Item2() { Id = 44, Name = "Tovi dddd" };

            var ret = (from a in arr
                       where a != null && a.Id >= 2 && a.Id < 900
                       // select (new  aaa() { Id = a.Id });
                       //select (a)).ToList<Item>();
                       select (Name: a.Name,Id:a.Id, Age: 23));


            var h =  ret.Count((a) => { if (a.Name.StartsWith("M")) return true; else return false; });

           var m =  ret.Max((item) => { return item.Name.Count(); });

            ret.Sum(item => item.Id);

            var l = (name: "dddd", ddd: 12);
            l.name = "sssss";
        
        }
    }
}
