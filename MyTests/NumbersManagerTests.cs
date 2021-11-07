using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace MyTests
{
    public class NumbersManagerTests
    {
        [Test]
        public void CheckCreateNumbersManager()
        {
            //Arrange
            var numbers = new List<int>() { 4, 1, 5, 7, 3, 2 };
            var numbersManager = new NumbersManager();
            Assert.IsInstanceOf(typeof(NumbersManager), numbersManager);
        }
        #region Ascending
        [Test]
        public void CheckAscendingPositiveNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { 4, 1, 5, 7, 3, 2 };
            var numbersManager = new NumbersManager();
            //Act
            var actual = numbersManager.SortNumbers(numbers, true);
            var expect = new List<int>() { 1, 2, 3, 4, 5, 7 };
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckAscendingNegativeNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { -4, -1, -5, -7, -3, -2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -7, -5, -4, -3, -2, -1 }, true));
        }

        [Test]
        public void CheckAscendingPositiveAndNegativeNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { -1, 4, -5, -7, 3, 2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -7, -5, -1, 2, 3, 4 }, true));
        }

        [Test]
        public void CheckAscendingPositiveAndNegativeNumbersWithZeroList()
        {
            //Arrange
            var numbers = new List<int>() { -4, 1, -5, 7, 0, 3, -2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -5, -4, -2, 0, 1, 3, 7 }, true));
        }

        [Test]
        public void CheckAscendingPositiveNumbersWithZeroList()
        {
            //Arrange
            var numbers = new List<int>() { 1, 4, 6, 0, 3, 2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, 1, 2, 3, 4, 6 }, true));
        }

        [Test]
        public void CheckAscendingNegativeNumbersWithZeroList()
        {
            //Arrange
            var numbers = new List<int>() { -1, -4, -6, 0 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -6, -4, -1, 0 }, true));
        }

        [Test]
        public void CheckAscendingZerosList()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0, 0 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, 0, 0 }, true));
        }
        #endregion
        #region Descending
        [Test]
        public void CheckDescendingPositiveNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { 4, 1, 5, 7, 3, 2 };
            var numbersManager = new NumbersManager();
            //Act
            var actual = numbersManager.SortNumbers(numbers, false);
            var expect = new List<int>() { 7, 5, 4, 3, 2, 1 };
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckDescendingPositiveNumbersAndZeroList()
        {
            //Arrange
            var numbers = new List<int>() { 1, 4, 0, 3, 2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 4, 3, 2, 1, 0 }, false));
        }

        [Test]
        public void CheckDescendingNegativeNumbersAndZeroList()
        {
            //Arrange
            var numbers = new List<int>() { -1, -4, -5, 0, -7, -3, -2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, -1, -2, -3, -4, -5, -7 }, false));
        }

        [Test]
        public void CheckDescendingNegativeNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { -1, -4, -5, -7, -3, -2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { -1, -2, -3, -4, -5, -7 }, false));
        }

        [Test]
        public void CheckDescendingPositiveAndNegativeNumbersList()
        {
            //Arrange
            var numbers = new List<int>() { -1, 4, -5, -7, 3, 2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 4, 3, 2, -1, -5, -7 }, false));
        }

        [Test]
        public void CheckDescendingPositiveAndNegativeNumbersWithZeroList()
        {
            //Arrange
            var numbers = new List<int>() { -4, 1, -5, 7, 0, 3, -2 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 7, 3, 1, 0, -2, -4, -5 }, false));
        }

        [Test]
        public void CheckDescendingZerosList()
        {
            //Arrange
            var numbers = new List<int>() { 0, 0, 0 };
            var numbersManager = new NumbersManager();
            Assert.Throws<Exception>(() => numbersManager.SortNumbers(new List<int>() { 0, 0, 0 }, false));
        }
        #endregion
    }
}

