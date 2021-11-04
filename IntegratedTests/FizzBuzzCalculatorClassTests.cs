using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace IntegratedTests
{
    class FizzBuzzCalculatorClassTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ChceckCreateFizzBuzzClassCalculator()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 1, 2);
            Assert.IsInstanceOf(typeof(FizzBuzzClass), fizzBuzzClass);
        }
        #region ByThreeAndFive
        [Test]
        public void CheckPositiveNumbersByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckcheckNegativeNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -7, -11);
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 7, 11);
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveAndNegativeNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 2, -8);
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeAndPositiveNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -2, 8);
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }
        #endregion
        #region ByThree
        [Test]
        public void CheckPositiveNumbersByThree()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 3, 33);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByThree()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -3, -33);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByThree()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 3, -6);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByThree()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -3, 6);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            Assert.IsTrue(actual == expect);
        }
        #endregion
        #region ByFive

        [Test]
        public void CheckPositiveNumbersByFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 5, 15);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, 5, -15);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -5, 15);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByFive()
        {
            //Arrange
            var calculator = new Calculator();
            var fizzBuzzClass = new FizzBuzzClass(calculator, -5, -15);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            Assert.IsTrue(actual == expect);
        }
        #endregion
    }
}
