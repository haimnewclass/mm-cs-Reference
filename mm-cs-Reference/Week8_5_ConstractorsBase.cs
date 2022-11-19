using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week8_5_ConstractorsBase
    {
        Child d = new Child();

    }

    class ParentAAA
    {
        public ParentAAA()
        {

        }
        public ParentAAA(int id,string name)
        {
        }
      

    }

class Child : ParentAAA
    {

        public Child() : base(12,"343434")
        {
            //

        }
        public Child(int id) : base(id + 10,"2323") { 
        //

        }
        public Child(int id,string name,int age) : base(12,"ddd") { }
        public Child(string name) : base(123,"****") { }
    }


}
