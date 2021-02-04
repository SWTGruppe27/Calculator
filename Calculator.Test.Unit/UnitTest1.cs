using Lommeregner;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    
    public class Tests
    {
        private Calculator1 uut;
        [SetUp]
        
        public void Setup()
        {
            uut = new Calculator1();
        }

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
        [Test]
        public void Add_Intigers_SumIsCorrect()
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
        [TestCase(1,2,3)]
        [TestCase(3, 3, 6)]
        [TestCase(11.11, 11.11, 22.22)]
        public void AddTest3cases(double n, double d, double q)
        {
            var result = uut.Add(n, d);
            Assert.That(q,Is.EqualTo(result));
        }
    }
}