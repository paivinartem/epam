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
    public class SubtractionTests
    {
        Calc calc = new Calc();

        [Test]
        public void SubtractionTest1()
        {
            Assert.AreEqual(0, calc.Subtraction(0, 0));
        }

        [Test]
        public void SubtractionTest2()
        {
            Assert.AreEqual(21, calc.Subtraction(28, 7));
        }

        [Test]
        public void SubtractionTest3()
        {
            Assert.AreEqual(double.MinValue, calc.Subtraction(1, double.MaxValue));
        }

        [Test]
        public void SubtractionTest4()
        {
            Assert.AreEqual(double.MinValue, calc.Subtraction(double.MinValue, 0));
        }

        [Test]
        public void SubtractionTest5()
        {
            Assert.AreEqual(0, calc.Subtraction(-1, -1));
        }
    }
}
