using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        //Remember last result!
        public double _lastResult;

        public double Add(double a, double b)
        {
            //update lastResult
            _lastResult = a + b;
            return _lastResult;
            
        }

        public double Subtract(double a, double b)
        {
            //update lastResult
            _lastResult = a - b;
            return _lastResult;
        }

        public double Multiply(double a, double b)
        {
            //update lastResult
            _lastResult = a * b;
            return _lastResult;
        }

        public double Power(double a, double b)
        {
            //update lastResult
            _lastResult = Math.Pow(a,b);
            return _lastResult;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                return 0;
            //update lastResult
            _lastResult = a / b;
            return _lastResult;
        }

        public double Accumulator
        {
            get { return _lastResult; }

            set { _lastResult = value; }
        }

    }
}





