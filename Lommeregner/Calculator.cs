using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner
{
    public class DivideByZeroException : Exception
    {
        public  DivideByZeroException() 
        {
            
        }
}
public class Calculator1
    {
        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;

        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;

        }
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;

        }
        

        public double Divide(double a, double b)
        {
            if(b==0) throw new DivideByZeroException();
            return Accumulator=a / b;
        }
    }
}
