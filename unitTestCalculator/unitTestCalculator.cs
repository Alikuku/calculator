using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace unitTestCalculator
{
    [TestFixture]
    public class unitTestCalculator
    {

        [Test]
        public void add4plus4_return8()
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Add(4, 4), Is.EqualTo(8).Within(0.01));
        }

        [Test]
        public void Subtract4minus2_return2()
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2).Within(0.01));
        }

        [Test]
        public void Multiply3gange3_return9()
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Multiply(3, 3), Is.EqualTo(9).Within(0.01));
        }

        [Test]
        public void Power2oploeftet4_return16()
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Power(2, 4), Is.EqualTo(16).Within(0.01));
        }

        [TestCase(10, 2, 5)]
        [TestCase(10, 0, 0)]
        public void Divide10divideretmed2og0_return5og0(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Divide(a, b));
        }
    }
}
