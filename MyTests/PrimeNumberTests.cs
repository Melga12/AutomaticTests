using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;

namespace MyTests
{
    public class PrimeNumberTests
    {

        [Test]
        public void ChceckCreatePrimeNumber()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { 2, 4, 6, 5, 7, 8 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            Assert.IsInstanceOf(typeof(PrimeNumber), primeNumber);
            Assert.IsTrue(primeNumber._numbersManager == mock.Object && primeNumber.Numbers == numbers && primeNumber.Ascending == true);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityAscending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { 2, 4, 6, 5, 7, 8 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityDescending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 8, 7, 6, 5, 4, 2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeAndPositiveNumbersDescending()
        {
            //Arrange
            var numbers = new List<int>() { -1, 2, 1, 0, -2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 2, 1, 0, -1, -2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeAndPositiveNumbersAscending()
        {
            //Arrange
            var numbers = new List<int>() { -2, -1, 1, 0, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -2, -1, 0, 1, 2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAscending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -6, -5, -4 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersDescending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { -4, -5, -6 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

    }

}
