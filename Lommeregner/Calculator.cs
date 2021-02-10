using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class DivideByZeroException : Exception
    {
        public DivideByZeroException()
        {

        }
    }

    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;

            return Accumulator;
        }

        public double Add(double addend)
        {
            double result = Accumulator + addend;

            Accumulator = result;

            return result;
        }


        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;

        }

        public double Subtract(double subtractor)
        {
            double result = Accumulator - subtractor;

            Accumulator = result;

            return result;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;

        }

        public double Multiply(double multiplier)
        {
            double result = Accumulator * multiplier;

            Accumulator = result;

            return result;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;

        }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return Accumulator = a / b;
        }

        public double Power(double exponent)
        {
            double result = Math.Pow(Accumulator, exponent);

            Accumulator = result;

            return result;
        }

        public double Divide(double a)
        {
            if (a == 0 || Accumulator == 0) throw new DivideByZeroException();

            double result = a / Accumulator;

            Accumulator = result;

            return result;
        }
    }
}
