using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week14_3_Nullable
    {
        public void Run()
        {
            // Nullable variables
            int a=0;
            int[] arr = new int[10];

            int? b;
            b = null;
            b = 12;
            b = null;

            bool? c = null;

            if(b==null)
            {

            }

            arr = null;
            if (arr == null)
            {

            }

            if (a == 0)
            {

            }

        }
    }
}
