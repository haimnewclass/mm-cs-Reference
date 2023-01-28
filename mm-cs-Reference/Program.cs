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
            Test1 t = new Test1();
            t.Ran();


            //Week14_4_IEnumerable week14_4_IEnumerable = new Week14_4_IEnumerable();
           // week14_4_IEnumerable.Run();
            Week14_2_Tasks week14_2_Tasks = new Week14_2_Tasks();
            week14_2_Tasks.Run();

            System.Threading.Thread.Sleep(900000);


            Week14_1_Threading week14_1_Threading = new Week14_1_Threading();
            week14_1_Threading.Run();

            return;
            Week13_1_JSOM.Run();
            Week12_7_Generics2<int>.Run();
            Week11_4_Delegate.Instance.Run();
            mm_cs_Working.Cars.Sql();

            Week10_4_Enum.Run();

            try
            {
                int r = Week10_2_Exception.Instance.test(10, 0);
                if(r==-999999)
                {
                    r = Week10_2_Exception.Instance.test(10, 0);
                }
                try
                {
                    int a;
                    GetA();
                    mm_cs_Reference.Patterns.Week9_2_Singletone week9_2_Singletone = new mm_cs_Reference.Patterns.Week9_2_Singletone();
                    week9_2_Singletone.Run();
                }
                catch(Exception e)
                {

                }

                try
                {
                    Week9_1_Consts.Run();
                    Week8_7_ClassParty week8_7_ClassParty = new Week8_7_ClassParty();
                    week8_7_ClassParty.Run();
                }
                catch(Exception e)
                {

                }

                try
                {
                    Week8_5_ClassFactory.Run();

                    // Week8_5_Statis.Student student = new Week8_5_Statis.Student("234234");
                    Week8_5_Statis week8_5_Statis = new Week8_5_Statis();
                    week8_5_Statis.Ran();
                   
                }
                catch(DivideByZeroException ex1)
                {

                }
                catch(OutOfMemoryException ex3)
                {

                }
                catch(Exception ex2)
                {

                }


            Week8_4_Static week8_4_Static = new Week8_4_Static();
            week8_4_Static.Run();
            Week8_4_Properties week8_4_Properties = new Week8_4_Properties();
            week8_4_Properties.RunProperty();
            Lunapark.IceCream ice;
            Park.IceCream park;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
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