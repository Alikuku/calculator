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
        [TestCase(1.5, 3.8, 5.3)]
        public void Add3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Add(a, b));
        }

        [TestCase(2, 6, 4, 12)]
        [TestCase(-5, 15, 1, 11)]
        [TestCase(8.9, 2.2, 10.5, 21.6)]
        public void Add3TestCasesWithLastresult(double a, double b, double c, double d)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Add(a, b);

            Assert.AreEqual(d, uut.Add(c));
        }

        [TestCase(4, 4, 0)]
        [TestCase(-9, 2, -11)]
        [TestCase(5.5, -5.5, 11)]
        public void Subtract3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Subtract(a, b));
        }

        [TestCase(12, 6, 4, 2)]
        [TestCase(11, 15, -4, 0)]
        [TestCase(3.9, 7.8, 5.2, -9.1)]
        public void Sub3TestCasesWithLastresult(double a, double b, double c, double d)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Subtract(a, b);

            Assert.AreEqual(d, uut.Subtract(c));
        }

        [TestCase(4, 4, 16)]
        [TestCase(2, -9, -18)]
        [TestCase(1.8, 3.2, 5.76)]
        public void Multiply3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(9, 3, 15, 405)]
        [TestCase(-6, 5, -103, 3090)]
        [TestCase(17.5, 2.8, 8.2, 401.8)]
        public void Multiply3TestCasesWithLastresult(double a, double b, double c, double d)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Multiply(a, b);

            Assert.That(uut.Multiply(c), Is.EqualTo(d).Within(0.01));
        }

        [TestCase(8, 1, 8)]
        [TestCase(2, 0, 1)]
        [TestCase(-16, 2, 256)]
        [TestCase(-16, 3, -4096)]
        public void Power2oploeftet4_return16(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Power(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(2, 6, 3, 262144)]
        [TestCase(-6, 2, 1, 36)]
        [TestCase(36, 513, 0, 1)]
        public void Power3TestCasesWithLastresult(double a, double b, double c, double d)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Power(a, b);

            Assert.That(uut.Power(c), Is.EqualTo(d).Within(0.01));
        }

        [TestCase(10, 2, 5)]
        [TestCase(4131, 81, 51)]
        [TestCase(10, 0, 0)]
        public void Divide10divideretmed2og0_return5og0(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Divide(a, b));
        }

        [TestCase(9, 3, 2, 1.5)]
        [TestCase(-6, 2, 3, -1)]
        [TestCase(18.5, 2, 9.25, 1)]
        public void Divide3TestCasesWithLastresult(double a, double b, double c, double d)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Divide(a, b);

            Assert.That(uut.Divide(c), Is.EqualTo(d).Within(0.01));
        }

        [TestCase(5, 5)] //Add 5 and 5
        public void Accumulator(double a, double b)
        {
            var uut = new Calculator.Calculator();

            //initialize array size of 5 named: resultArray
            double[] resultArray = new double[5];

            //initialize elements of array resultArray
            resultArray[0] = uut.Add(a, b);
            Assert.AreEqual(resultArray[0],uut._lastResult);

            resultArray[1] = uut.Subtract(a, b);
            Assert.AreEqual(resultArray[1], uut._lastResult);

            resultArray[2] = uut.Multiply(a, b);
            Assert.AreEqual(resultArray[2], uut._lastResult);

            resultArray[3] = uut.Power(a, b);
            Assert.AreEqual(resultArray[3], uut._lastResult);

            resultArray[4] = uut.Divide(a, b);
            Assert.AreEqual(resultArray[4], uut._lastResult);
        }   
    }
}
