using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner
{
    public class Calculator1
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
            double result = Accumulator + subtractor;

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
            double result = Accumulator + multiplier;

            Accumulator = result;

            return result;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;

        }

        public double Power(double exponent)
        {
            double result = Math.Pow(Accumulator, exponent);

            Accumulator = result;

            return result;
        }
    }
}
