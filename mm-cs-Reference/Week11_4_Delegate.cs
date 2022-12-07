using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week11_4_Delegate
    {
        private Week11_4_Delegate() { }
		private static readonly Week11_4_Delegate _instance = new Week11_4_Delegate();

		public static Week11_4_Delegate Instance
		{
			get { return _instance;  }
		 
		}

		public delegate int Tax_delegate(int price);

		public int CalcTaxInTlv(int price1)
		{
			return price1 + 20;
		}

        public int CalcTaxInEilat(int price2)
        {
            return price2 - 20;
        }


		public void Run()
		{
			int cola = 20;
			int pepsi = 15;

			Tax_delegate func;
			 
			func = CalcTaxInEilat;
			func(cola);

			func = CalcTaxInTlv;
			func(pepsi);

        }
    }
}
