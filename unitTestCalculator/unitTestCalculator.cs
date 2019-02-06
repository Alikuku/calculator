using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unitTestCalculator
{
    [TestFixture]
    public class unitTestCalculator
    {
        [TestCase(4, 4, 8)]
        [TestCase(-2, 9, 7)]
        [TestCase(1.65, 3, 4.65)]
        public void Add3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Add(a, b));
        }

        [TestCase(4, 4, 0)]
        [TestCase(-9, 2, -11)]
        [TestCase(5.15, 3, 2.15)]
        public void Subtract3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(4, 4, 16)]
        [TestCase(-2, 3, -6)]
        [TestCase(2.75, 4, 11)]
        public void Multiply3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(4, 4, 256)]
        [TestCase(-3, 4, 81)]
        [TestCase(1.33, 4, 3.12900721)]
        public void Power3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Power(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(12, 2, 6)] 
        [TestCase(2, 0, 0)]
        [TestCase(4, 2.5, 1.6)]
        public void DivideTestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Divide(a, b), Is.EqualTo(c).Within(0.01));
        }


        //Accumulator working with Last result!//

        [TestCase(5, 12)]
        [TestCase(2, 9)]
        [TestCase(3.3, 10.3)]
        public void AccumulatorTestAdd(double a, double b)
        {
            var uut = new Calculator.Calculator();

            //set last result
            uut.Add(5, 2); //=7

            Assert.AreEqual(uut.Add(a, uut._lastResult),b);
        }

        [TestCase(6, 3)]
        [TestCase(-3, -6)]
        [TestCase(3.33, 0.33)]
        public void AccumulatorTestSubtract(double a, double b)
        {
            var uut = new Calculator.Calculator();
            
            //set last result
            uut.Subtract(5,2); //=3

            Assert.That(uut.Subtract(a, uut._lastResult), Is.EqualTo(b).Within(0.01));
        }

        [TestCase(2, 42)]
        [TestCase(-4, -84)]
        [TestCase(2.25, 47.25)]
        public void AccumulatorTestMultiply(double a, double b)
        {
            var uut = new Calculator.Calculator();

            //set last result
            uut.Multiply(3, 7); //=21

            Assert.AreEqual(uut.Multiply(a, uut._lastResult), b);
        }

        [TestCase(10, 289.927110329)]
        [TestCase(3, 14.955823617)]
        [TestCase(1.25, 1.7322893771)]
        public void AccumulatorTestPower(double a, double b)
        {
            var uut = new Calculator.Calculator();

            //set last result
            uut.Power(2, 1.3); //=2.462288827

            Assert.That(uut.Power(a, uut._lastResult), Is.EqualTo(b).Within(0.01));
        }

        [TestCase(5, 5)] //Add 5 and 5
        [TestCase(-2, 5)] //Add 5 and 5
        [TestCase(1.75, 5)] //Add 5 and 5
        public void Accumulator(double a, double b)
        {
            var uut = new Calculator.Calculator();

            Assert.AreEqual(uut.Add(a, b),uut._lastResult);
            Assert.AreEqual(uut.Subtract(a, b), uut._lastResult);
            Assert.AreEqual(uut.Multiply(a, b), uut._lastResult);
            Assert.AreEqual(uut.Power(a, b), uut._lastResult);
            Assert.AreEqual(uut.Divide(a, b), uut._lastResult);
        }   
    }
}
