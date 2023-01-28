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

    internal class Test1
    {
        
        
        public void Ran()
        {
            Item[] arr = new Item[10];
            arr[0] = new Item() { Id = 1, Name = "Avi" };
            arr[1] = new Item() { Id = 2, Name = "Moshe" };
            arr[2] = new Item() { Id = 3, Name = "Meir" };
            arr[3] = new Item() { Id = 4, Name = "Tovi" };


            var ret = (from item in arr
                       where item !=null && item.Id => 3 && item.Id < 900
                       select item ).ToList();
        }
    }
}
