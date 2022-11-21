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
        static int GetA()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            int a;
            GetA();
            mm_cs_Reference.Patterns.Week9_2_Singletone week9_2_Singletone = new mm_cs_Reference.Patterns.Week9_2_Singletone();
            week9_2_Singletone.Run();

            Week9_1_Consts.Run();
            Week8_7_ClassParty week8_7_ClassParty = new Week8_7_ClassParty();
            week8_7_ClassParty.Run();



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