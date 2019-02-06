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

        //Overloaded Add- function to accomplish usage of accumulator
        public double Add(double a)
        {
            _lastResult += a;
            return _lastResult;
        }

        public double Subtract(double a, double b)
        {
            //update lastResult
            _lastResult = a - b;
            return _lastResult;
        }

        //Overloaded Subtract- function to accomplish usage of accumulator
        public double Subtract(double a)
        {
            _lastResult -= a;
            return _lastResult;
        }

        public double Multiply(double a, double b)
        {
            //update lastResult
            _lastResult = a * b;
            return _lastResult;
        }

        //Overloaded Multiply- function to accomplish usage of accumulator
        public double Multiply(double a)
        {
            _lastResult = a * _lastResult;
            return _lastResult;
        }

        public double Power(double a, double b)
        {
            //update lastResult
            _lastResult = Math.Pow(a,b);
            return _lastResult;
        }

        //Overloaded Power- function to accomplish usage of accumulator
        public double Power(double a)
        {
            _lastResult = Math.Pow(_lastResult, a);
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

        //Overloaded Divide- function to accomplish usage of accumulator
        public double Divide(double a)
        {
            if (a == 0)
                return 0;
            _lastResult = _lastResult / a;
            return _lastResult;
        }

        public double Accumulator
        {
            //setter & getter
            get { return _lastResult; }

            set { _lastResult = value; }
        }
    }
}





