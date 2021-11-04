using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;

namespace MyTests
{
    public class TextOperationTests
    {
        [Test]
        public void CheckCreateTextOperation()
        {
            //Arrange
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("mama", "tata")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "mama", "tata");
            Assert.IsInstanceOf(typeof(TextOperation), textOperation);
            Assert.IsTrue(textOperation.LengthOperation == mock.Object && textOperation.Text1 == "mama" && textOperation.Text2 == "tata");
        }

        [Test]
        public void CheckCreatePalindrom()
        {
            //Arrange
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("bark", "krab")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "bark", "krab");
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Palindrom";
            Assert.IsTrue(textOperation.LengthOperation == mock.Object && textOperation.Text1 == "bark" && textOperation.Text2 == "krab");
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckCreateAnagram()
        {
            //Arrange
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("arbuz", "burza")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "arbuz", "burza");          
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Anagram";
            //Assert.Pass();           
            Assert.IsTrue(actual == expect);
            Assert.IsTrue(textOperation.LengthOperation == mock.Object && textOperation.Text1 == "arbuz" && textOperation.Text2 == "burza");
        }

        [Test]
        public void CheckCreateBrak()
        {
            //Arrange
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("kot", "lot")).Returns(true);
            var textOperation = new TextOperation(mock.Object, "kot", "lot");
            //Act
            var actual = textOperation.GetNameCompare();
            var expect = "Brak";
            Assert.IsTrue(textOperation.LengthOperation == mock.Object && textOperation.Text1 == "kot" && textOperation.Text2 == "lot");
            Assert.IsTrue(actual == expect);
        }

        [Test]
        public void CheckCreateException()
        {
            //Arrange
            var mock = new Mock<ILengthOperation>();
            mock.Setup(m => m.CompareLength("kot", "pies")).Returns(false);
            var textOperation = new TextOperation(mock.Object, "kot", "pies");
            Assert.Throws<Exception>(() => textOperation.GetNameCompare());
        }
    }
}



