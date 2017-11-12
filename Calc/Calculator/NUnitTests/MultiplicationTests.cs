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
    public class MultiplicationTests
    {
        Calc calc = new Calc();

        [Test]
        public void MultiTest1()
        {
            Assert.AreEqual(0, calc.Multiplication(0, 7));
        }

        [Test]
        public void MultiTest2()
        {
            Assert.AreEqual(1, calc.Multiplication(1, 1));
        }

        [Test]
        public void MultiTest3()
        {
            Assert.AreEqual(double.PositiveInfinity , calc.Multiplication(4, double.MaxValue));
        }

        [Test]
        public void MultiTest4()
        {
            Assert.AreEqual(double.NegativeInfinity, calc.Multiplication(double.MaxValue, double.MinValue));
        }

        [Test]
        public void MultiTest5()
        {
            Assert.AreEqual(121, calc.Multiplication(-11, -11));
        }
    }
}
