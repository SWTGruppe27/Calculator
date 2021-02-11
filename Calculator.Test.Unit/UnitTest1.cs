using System;
using System.ComponentModel;
using Calculator;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    
    public class Tests
    {
        private Calculator uut;
        [SetUp]
        
        public void Setup()
        {
            uut = new Calculator();
        }

        //*** Add ***
        [Test]
        public void Add_Integers_SumIsCorrect()
        {
            //Act
            var result = uut.Add(13, 1);
            //Assert
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void Add_Zero_SumIsCorrect()
        {
            //Act
            var result = uut.Add(0, 0);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_ZeroAnd10_SumIsCorrect()
        {
            //Act
            var result = uut.Add(10, 0);
            //Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Add_Decimal_SumIsCorrect()
        {
            //Act
            var result = uut.Add(10.1200, 11.3300);
            //Assert
            Assert.That(result, Is.EqualTo(21.45));
        }

        [TestCase(4, 2, 16)]
        [TestCase(5, 7, 78125)]
        [TestCase(2.2, 3, 10.648)]
        public void Power_Test3casesOfPower_SumIsCorrect(double a, double b, double c)
        {
            var result = uut.Power(a, b);
            Assert.That(c, Is.InRange(result-0.1,result+0.1));
        }


        [TestCase(1, 2, 3)]
        [TestCase(3, 3, 6)]
        [TestCase(11.11, 11.11, 22.22)]
        public void Add_Test3cases_SumIsCorrect(double n, double d, double q)
        {
            var result = uut.Add(n, d);
            Assert.That(q, Is.EqualTo(result));
        }

        [TestCase(2, 4)]
        [TestCase(5, 10)]
        [TestCase(0, 0)]
        public void Add_overloadedFunction_SumIsCorrect(double a, double result)
        {
            uut.Add(a);
            Assert.That(uut.Add(a), Is.EqualTo(result));
        }


        //*** Subtract ***
        [TestCase(4, 2, 2)]
        [TestCase(-4, -3, -1)]
        [TestCase(-2, 5, -7)]
        public void Subtract_Test3Cases_SumIsCorrect(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 0)]
        [TestCase(-3, 5)]
        [TestCase(5, -3)]
        public void Subtract_Overloaded_SumIsCorrect(double b, double result)
        {
            uut.Subtract(4, 2);
            Assert.That(uut.Subtract(b), Is.EqualTo(result));
        }

        [TestCase(2, -4)]
        [TestCase(5, -10)]
        [TestCase(0, 0)]
        public void Subtract_overloadedFunction_SumIsCorrect(double a, double result)
        {
            uut.Subtract(a);
            Assert.That(uut.Subtract(a), Is.EqualTo(result));
        }


        //*** Multiply ***
        [Test]
        //method, scenario and expected result
        public void Multiply_3Times3_ProductIsCorrect()
        {
            //Act
            var result = uut.Multiply(3, 3);
            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Multiply_0Times3_ProductIsCorrect()
        {
            //Act
            var result = uut.Multiply(0, 3);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_3Times0_ProductIsCorrect()
        {
            //Act
            var result = uut.Multiply(3, 0);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_decimals_ProductIsCorrect()
        {
            //Act
            var result = uut.Multiply(3.14, 3);
            //Assert
            Assert.That(result, Is.EqualTo(3*3.14));
        }

        [TestCase(2, 0)]
        [TestCase(5, 0)]
        [TestCase(0, 0)]
        public void Multiply_overloadedFunction_SumIsCorrect(double a, double result)
        {
            uut.Multiply(a);
            Assert.That(uut.Multiply(a), Is.EqualTo(result));
        }


        //*** Divide ***
        [TestCase(10, 2, 5)]
        [TestCase(0, 3, 0)]
        [TestCase(11.11, 11.11, 1)]
        public void Divide_Test3cases_ResultIsCorrect(double n, double d, double q)
        {
            var result = uut.Divide(n, d);
            Assert.That(q, Is.EqualTo(result));
        }

        [TestCase(2, 1)]
        [TestCase(5, 0.4)]
        [TestCase(-10, -0.2)]
        public void Divide_overloadedFunction_SumIsCorrect(double b, double result)
        {
            uut.Divide(4, 2);
            Assert.That(uut.Divide(b), Is.EqualTo(result));
        }

        [Test]
        public void Divide_Zero_ExceptionIsThrown()
        {
            //Act and Assert
            Assert.That( () => uut.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Divide_ZeroOverloaded_ExceptionIsThrown()
        {
            //Act and Assert
            Assert.That(() => uut.Divide(10), Throws.TypeOf<DivideByZeroException>());
        }


        //*** Clear ***
        [Test]
        public void Clear_AddAccumulator_AccumulatorZero()
        {
            //Act
            uut.Add(2, 3);
            uut.Clear();
            double temp = uut.Accumulator;
            //Assert
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void Clear_SubtractAccumulator_AccumulatorZero()
        {
            //Act
            uut.Subtract(2, 3);
            uut.Clear();
            double temp = uut.Accumulator;
            //Assert
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void Clear_MultiplyAccumulator_AccumulatorZero()
        {
            //Act
            uut.Multiply(2, 3);
            uut.Clear();
            double temp = uut.Accumulator;
            //Assert
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void Clear_PowerAccumulator_AccumulatorZero()
        {
            //Act
            uut.Power(2, 3);
            uut.Clear();
            double temp = uut.Accumulator;
            //Assert
            Assert.That(temp, Is.EqualTo(0));
        }

        [Test]
        public void Clear_DivideAccumulator_AccumulatorZero()
        {
            //Act
            uut.Divide(2, 3);
            uut.Clear();
            double temp = uut.Accumulator;
            //Assert
            Assert.That(temp, Is.EqualTo(0));
        }


        //*** Accumulator ***
        [TestCase(3, 4, 14)]
        [TestCase(3, 3, 12)]
        [TestCase(11.11, 11.11, 44.44)]
        public void Add_Accumulator_sumIsCorrect(double a, double b, double result)
        {
            uut.Add(a, b);
            Assert.That(uut.Accumulator + uut.Add(a, b),Is.EqualTo(result)); 
        }

        [TestCase(2, 3, 12)]
        [TestCase(5, 5, 50)]
        [TestCase(0, 4, 0)]
        public void Multiply_Accumulator_SumIsCorrect(double a, double b, double result)
        {
            uut.Multiply(a, b);
            Assert.That(uut.Accumulator + uut.Multiply(a,b),Is.EqualTo(result));
        }
    }
}