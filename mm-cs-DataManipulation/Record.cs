using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_DataManipulation
{
    public class ARecord
    { 
        public void Run()
        {
            ItemCar itemCar1 = new ItemCar() { Description = "Best car", Id = 1, Name = "Bugati" };          
            ItemCar itemCar3 = new ItemCar() { Description = "Best car", Id = 1, Name = "Bugati" };
            ItemCar itemCar2 = new ItemCar() { Description = "nice car", Id = 2, Name = "Suzuki" };

            if (itemCar1 == itemCar2)
            {

            }

            if (itemCar1 == itemCar3)
            {

            }
          
            itemCar3.Name = "Subaro";
            if (itemCar1 == itemCar3)
            {

            }            
        }
    }

    public record ItemCar
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }    
    }

}
