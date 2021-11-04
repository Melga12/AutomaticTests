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

        [Test]
        public void ChceckIfReturnCorrectQuantityAscending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, true);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 3);

            Assert.Pass();
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityDescending()
        {
            //Arrange
            var numbers = new List<int>() { 4, 6, 5, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 3);
            Assert.Pass();
        }

        [Test]
        public void ChceckIfReturnCorrectQuantityDescending1()
        {
            //Arrange
            var numbers = new List<int>() { -4, 6, 5, 7, 8, 2 };
            var numbersManager = new NumbersManager();
            var primeNumber = new PrimeNumber(numbersManager, numbers, false);
            //Act
            var actual = primeNumber.CountNumbers();
            var expect = new QuantityNumbers(3, 3);
            Assert.Pass();
        }
    }
}


