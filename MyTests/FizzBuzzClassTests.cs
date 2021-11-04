using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;

namespace MyTests
{
    public class FizzBuzzClassTests
    {
        [Test]
        public void CheckCreateFizzBuzzClass()
        {
            //Arrange
            var mock = new Mock<ICalculatorClass>();
            var fizzBuzzClass = new FizzBuzzClass(mock.Object, 1, 2);
            //Assert
            Assert.IsInstanceOf(typeof(FizzBuzzClass), fizzBuzzClass);
            Assert.IsTrue(fizzBuzzClass._calculatorClass == mock.Object && fizzBuzzClass.Number1 == 1 && fizzBuzzClass.Number2 == 2);
        }
        #region FizzBuzz
        [Test]
        public void CheckPositiveNumbersByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(15, 30)).Returns(45);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, 15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(-15, -30)).Returns(-45);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, -15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(15, -30)).Returns(-15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, 15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(-15, 30)).Returns(15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, -15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckcheckNegativeNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(-7, -11)).Returns(-18);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, -7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(7, 11)).Returns(18);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, 7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveAndNegativeNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(7, -11)).Returns(-4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, 7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeAndPositiveNumbersIndivisibleByThreeAndFive()
        {
            //Arrange
            var mockAddNumber1 = new Mock<ICalculatorClass>();
            mockAddNumber1.Setup(man => man.Add(-7, 11)).Returns(4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber1.Object, -7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }
        #endregion
        #region Fizz
        [Test]
        public void CheckPositiveNumbersByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(15, 30)).Returns(-15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, 15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(-15, -30)).Returns(15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, -15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(15, -30)).Returns(-15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, 15, -30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(-15, 30)).Returns(15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, -15, 30);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Fizz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckcheckPositiveNumbersIndivisibleByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(7, 11)).Returns(-4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, 7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeNumbersIndivisibleByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(-7, -11)).Returns(4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, -7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeAndPositiveNumberIndivisibleByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(-7, 11)).Returns(4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, -7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveAndNegativeNumberIndivisibleByThree()
        {
            //Arrange
            var mockAddNumber2 = new Mock<ICalculatorClass>();
            mockAddNumber2.Setup(man => man.Substruct(7, -11)).Returns(-4);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber2.Object, 7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }
        #endregion
        #region Buzz
        [Test]
        public void CheckPositiveNumbersByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(5, 3)).Returns(15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, 5, 3);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeNumbersByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(-5, -3)).Returns(15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, -5, -3);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckNegativeAndPositiveNumbersByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(-5, 3)).Returns(-15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, -5, 3);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckPositiveAndNegativeNumbersByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(5, -3)).Returns(-15);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, 5, -3);
            //Act
            var actual = fizzBuzzClass.CheckFizzBuzz();
            var expect = "Buzz";
            //Assert
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckcheckPositiveNumbersIndivisibleByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(7, 11)).Returns(77);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, 7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeNumberIndivisibleByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(-7, -11)).Returns(77);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, -7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckNegativeAndPositiveNumberIndivisibleByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(-7, 11)).Returns(-77);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, -7, 11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }

        [Test]
        public void CheckcheckPositiveAndNegativeNumbersIndivisibleByFive()
        {
            //Arrange
            var mockAddNumber3 = new Mock<ICalculatorClass>();
            mockAddNumber3.Setup(man => man.Multiply(7, -11)).Returns(-77);
            var fizzBuzzClass = new FizzBuzzClass(mockAddNumber3.Object, 7, -11);
            //Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());
        }
        #endregion
    }
}