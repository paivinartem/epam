using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace NUnitTests
{
    [TestFixture]
    public class AmountTests
    {
        Calc calc = new Calc();

        [Test]
        public void AmountTest1()
        {
            Assert.AreEqual(35, calc.Amount(14, 21));
        }

        [Test]
        public void AmountTest2()
        {
            Assert.AreEqual(-1, calc.Amount(-5, 4));
        }

        [Test]
        public void AmountTest3()
        {
            Assert.AreEqual(double.MaxValue, calc.Amount(1, double.MaxValue));
        }

        [Test]
        public void AmountTest4()
        {
            Assert.AreEqual(double.MinValue, calc.Amount(-1, double.MinValue));
        }

        [Test]
        public void AmountTest5()
        {
            Assert.AreEqual(0, calc.Amount(-1, 1));
        }
    }
}

