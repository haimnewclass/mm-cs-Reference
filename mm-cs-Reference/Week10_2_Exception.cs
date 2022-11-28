using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week10_2_Exception
    {
        private Week10_2_Exception()
        {

        }

        static readonly Week10_2_Exception _instance  = new Week10_2_Exception();

        public static Week10_2_Exception Instance
        {
            get { return _instance; }
            
        }

        public int  test(int a,int b)
        {
            int c=-1;

            int g = 909;
            for (int i = 0; i < 20; i++)
            {

            }
            try
            {

                System.IO.File.ReadAllText(@"c:\kuku1.txt");
                c = a / b;
            }
            catch (DivideByZeroException ex1)
            {
                c = 0;
            }
            catch (FileNotFoundException ex4)
            {

            }
            catch (OutOfMemoryException ex3)
            {

            }
            catch (Exception ex2)
            {
                 
            }



            //g = 89;
            return c;
        }

    }
}
