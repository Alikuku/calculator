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
        [TestCase(2, 9, 11)]
        [TestCase(1, 3, 4)]
        public void Add3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Add(a, b));
        }

        [TestCase(4, 8)]
        [TestCase(2, 10)]
        [TestCase(4, 14)]
        public void Add3TestCasesWithLastresult(double a, double b)
        {
            var uut = new Calculator.Calculator();

            //Set last result!
            uut.Add(2, 2);

            Assert.AreEqual(b, uut.Add(a, b));
        }

        [TestCase(4, 4, 0)]
        [TestCase(9, 2, 7)]
        [TestCase(5, 3, 2)]
        public void Subtract3TestCases(double a, double b, double c)
        {
            var uut = new Calculator.Calculator();
            Assert.AreEqual(c, uut.Subtract(a, b));
        }

        [TestCase(4, 4, 8)]
        [TestCase(2, 9, 11)]
        [TestCase(1, 3, 4)]
        public void Multiply3gange3_return9()
        {
            var uut = new Calculator.Calculator();
            Assert.That(uut.Multiply(3, 3), Is.EqualTo(9).Within(0.01));
        }

        [TestCase(4, 4, 8)]
        [TestCase(2, 9, 11)]
        [TestCase(1, 3, 4)]
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
