using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;


namespace MyTests
{
    public class LengthOperationTests
    {
        LengthOperation lengthOperation;

        [SetUp]
        public void CheckCreateLengthOperation()
        {
            //Arrange
            lengthOperation = new LengthOperation();
            Assert.IsInstanceOf(typeof(LengthOperation), lengthOperation);
        }

        [Test]
        public void CheckCompareTwoWordsOfTheSameLengths()
        {
            //Act
            var actual = lengthOperation.CompareLength("mama", "tata");
            var expect = true;
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCompareTwoWordsOfTheDifferentLengths()
        {
            //Act
            var actual = lengthOperation.CompareLength("mama", "wujek");
            var expect = false;
            Assert.AreEqual(actual, expect);
        }

    }
}

