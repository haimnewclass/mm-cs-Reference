using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using Lunapark;

namespace mm_cs_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Week8_5_ClassFactory.Run();

            // Week8_5_Statis.Student student = new Week8_5_Statis.Student("234234");
            Week8_5_Statis week8_5_Statis = new Week8_5_Statis();
            week8_5_Statis.Ran();


                




             Week8_4_Static week8_4_Static = new Week8_4_Static();
            week8_4_Static.Run();
            Week8_4_Properties week8_4_Properties = new Week8_4_Properties();
            week8_4_Properties.RunProperty();
            Lunapark.IceCream ice;
            Park.IceCream park;
 

              

        }


    }
}




namespace Park
{
    internal class Candy
    {
        BubbleGum BubbleGum;
    }

}