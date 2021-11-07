using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace IntegratedTests
{
    public class PrimeNumbersManager
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCreatePrimeNumbers()
        {
            //Arrange
            var numbers = new List<int>();
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.IsInstanceOf(typeof(PrimeNumber), primeNumber);
            Assert.Pass();
        }
        #region Ascending
        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAscending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Pass();
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAscending()

        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5, -7, -8, -2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -8, -7, -6, -5, -4, -2 }, true));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAndZeroAscending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 0, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -7, -5, -1, 0, 2, 3, 4 }, true));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAndZeroAscending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5, 0, -7, -8, -2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -8, -7, -6, -5, -4, -2, 0 }, true));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersAscending()
        {
            //Arrange
            var numbers = new List<int>() { -7, 4, -5, 3, -1, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -7, -5, -1, 2, 3, 4 }, true));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersAndZeroAscending()
        {
            //Arrange
            var numbers = new List<int>() { -7, 4, -5, 0, 3, -1, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -7, -5, -1, 0, 2, 3, 4 }, true));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityZerosAscending()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0, 0 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, 0, 0 }, true));
        }
        #endregion
        #region Descending
        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersDescending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Pass();
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersDescending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -6, -5, -7, -8, -2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Pass();
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersDescending()
        {
            //Arrange
            var numbers = new List<int>() { -7, 4, -5, 3, -1, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 4, 3, 2, -1, -5, -7 }, false));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveAndNegativeNumbersAndZeroDescending()
        {
            //Arrange
            var numbers = new List<int>() { -7, 4, -5, 0, 3, -1, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 4, 3, 2, 0, -1, -5, -7 }, false));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityPositiveNumbersAndZeroDescending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 5, 0, 3, 1 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 5, 4, 3, 1, 0 }, false));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityNegativeNumbersAndZeroDescending()
        {
            //Arrange
            var numbers = new List<int>() { -4, -5, 0, -3, -1 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, -1, -3, -4, -5 }, false));
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityZerosDescending1()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0, 0 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, 0, 0 }, false));
        }
        #endregion

    }
}


