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
        #region Ascending
        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAscending()
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
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAscending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5, -2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -6, -5, -4, -2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 0);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAndZeroAscending()
        {
            //Arrange
            var numbers = new List<int>() { 1, 0, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { 0, 1, 2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 2);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersAscending()
        {
            //Arrange

            var numbers = new List<int>() { -4, 4, -6, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -6, -4, 2, 4 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersAndZerosAscending()
        {
            //Arrange
            var numbers = new List<int>() { -4, 4, 0, -6, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -6, -4, 0, 2, 4 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAndZeroAscending()
        {
            //Arrange
            var numbers = new List<int>() { -4, 0, -6, -5 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { -6, -5, -4, 0 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityZerosAscending()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, true)).Returns(new List<int>() { 0, 0 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 0);
            //Assert
            Assert.IsFalse(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }
        #endregion
        #region Descending
        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersDescending()
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
            var numbers = new List<int>() { -1, 2, 1, -2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 2, 1, -1, -2 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(1, 3);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAndZeroDescending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 0, 7, 8, 2 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 8, 7, 6, 5, 4, 2, 0 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeAndPositiveNumbersAndZeroDescending()
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

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAndZeroDescending()
        {
            //Arrange
            var numbers = new List<int>() { -4, 0, -6, -5 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 0, -4, -5, -6 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 4);
            //Assert
            Assert.IsTrue(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityZerosDescending()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0 };
            var mock = new Mock<INumbersManager>();
            mock.Setup(m => m.SortNumbers(numbers, false)).Returns(new List<int>() { 0, 0 });
            var primeNumber = new PrimeNumber(mock.Object, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(0, 0);
            //Assert
            Assert.IsFalse(actual.QuantityPrimeNumbers == expect.QuantityPrimeNumbers && actual.QuantityNotPrimeNumbers == expect.QuantityNotPrimeNumbers);
        }

        #endregion
    }

}
