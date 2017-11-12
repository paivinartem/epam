using NUnit.Framework;
using Calculator;

namespace NUnitTests
{
    [TestFixture]
    public class DivisionTests
    {
        Calc calc = new Calc();

        [Test]
        public void DivisionTest1()
        {
            Assert.AreEqual(0, calc.Division(0, 3));
        }

        [Test]
        public void DivisionTest2()
        {
            Assert.AreEqual(29, calc.Division(29, 1));
        }

        [Test]
        public void DivisionTest3()
        {
            Assert.AreEqual(-4, calc.Division(-12, 3));
        }

        [Test]
        public void DivisionTest4()
        {
            Assert.AreEqual(double.NaN, calc.Division(0, 0));
        }

        [Test]
        public void DivisionTest5()
        {
            Assert.AreEqual(double.PositiveInfinity, calc.Division(7, 0));
        }
    }
}
