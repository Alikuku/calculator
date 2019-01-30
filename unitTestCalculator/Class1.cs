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
        public void add2plus4()
        {
            var uut = new calculator.Calculator();
            Assert.That(uut.Add(2, 4), Is.EqualTo(6));

        }

        [Test]
        public void sub2minus2()
        {
            var uut = new calculator.Calculator();
            Assert.That(uut.Subtract(2, 2), Is.EqualTo(0));
        }

        [Test]
        public void gang2gang2()
        {
            var uut = new calculator.Calculator();
            Assert.That(uut.Multiply(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void pow2pow2()
        {
            var uut = new calculator.Calculator();
            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }
    }
}
