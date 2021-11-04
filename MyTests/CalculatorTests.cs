using ApplicationToLearnTest;
using NUnit.Framework;
using System;
using System.Threading;

namespace MyTests
{
    public class CalculatorTests
    {
        Calculator calculator;


        [SetUp]
        public void CheckIfCalculatorCreate()
        {
            calculator = new Calculator();
            Assert.IsInstanceOf(typeof(Calculator), calculator);
        }
        #region add
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Add(1, 2);
            var expect = 3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //Act
            var actual = calculator.Add(1, -2);
            var expect = -1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            //Act
            var actual = calculator.Add(-1, 2);
            var expect = 1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Add(-1, -2);
            var expect = -3;
            //Assert
            Assert.IsTrue(actual == expect);
        }
        #endregion
        #region divide
        [Test]
        public void DivideNegativeNumberByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-5, 0));
        }

        [Test]
        public void DivideTwoZeros()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(0, 0));
        }

        [Test]
        public void DividePositiveNumberByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Divide(6, 2);
            var expect = 3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            //Act
            var actual = calculator.Divide(6, -2);
            var expect = -3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividedNegativeAndPositiveNumbers()
        {
            //Act
            var actual = calculator.Divide(-6, 2);
            var expect = -3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Divide(-6, -2);
            var expect = 3;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region multiply

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            //Act
            var actual = calculator.Multiply(-1, 2);
            var expect = -2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            //Act
            var actual = calculator.Multiply(1, -2);
            var expect = -2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Multiply(-1, -2);
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Multiply(1, 2);
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region substruct

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //Act
            var actual = calculator.Substruct(3, 2);
            var expect = 1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            //Act
            var actual = calculator.Substruct(-3, -2);
            var expect = -1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            //Act
            var actual = calculator.Substruct(-3, 2);
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            //Act
            var actual = calculator.Substruct(3, -2);
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);

        }
        #endregion
    }

}

