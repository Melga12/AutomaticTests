using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace IntegratedTests
{
    public class TextLengthOperationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCreateTextOperation()
        {
            //Arrange
            var lengthOperation = new LengthOperation();
            var textOperation = new TextOperation(lengthOperation, "matka", "córka");
            Assert.IsInstanceOf(typeof(TextOperation), textOperation);
            Assert.Pass();
        }

        [Test]
        public void CheckCreatePalindrom()
        {
            //Arrange
            var lengthOperation = new LengthOperation();
            var textOperation = new TextOperation(lengthOperation, "krab", "bark");
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Palindrom";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckCreateAnagram()
        {
            //Arrange
            var lengthOperation = new LengthOperation();
            var textOperation = new TextOperation(lengthOperation, "arbuz", "burza");
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Anagram";
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckCreateBrak()
        {
            //Arrange
            var lengthOperation = new LengthOperation();
            var textOperation = new TextOperation(lengthOperation, "kot", "lot");
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Brak";
            Assert.IsTrue(actual == expect);
        }

    }
}





