using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mm_cs_Reference.Test
{
    [TestFixture]
    internal class TestCalc
    {
        
        [SetUp]
        public void Init()
        {

        }

        [Test]
        [Category ("This is my Test")]
        [Order(10)]
        public void RunTest1()
        {
            int a = 20;
            int b = 21;
            
            Assert.AreEqual(a, b,"Should be Equal");
            
        }

        [Test , Order(4),  Ignore("Have not finished yet")]        
        public void RunTest2()
        {
            int a = 21;
            int b = 20;
            int c = a + b;
            Week17_Calc myCalc = new Week17_Calc();

            Assert.That(myCalc.Plus(a, b), Is.InRange(10, 1000));
            Assert.That(myCalc.Plus(a, b), Is.LessThan(800));
            Assert.AreEqual(c, myCalc.Plus(a,b));
        }

        
        public void RunTest4(int a,int b)
        {
            int c = a + b;
            Week17_Calc myCalc = new Week17_Calc();


            Assert.AreEqual(c+2, myCalc.Plus(a, b));
        }
        [Test]
        public void RunTest3()
        {
            for (int i = 0; i < 10; i++)
            {
              RunTest4(i, i);                                               
            }
            
        }
    }
}
