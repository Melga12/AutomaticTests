
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;

namespace MyTests
{
    public class CalcTest
    {
        [Test]
        public void CreateCalc()
        {
            //Arrange
            var mock = new Mock<IRandomize>();
            var calc = new Calc(3, 6, 34, 100, mock.Object, mock.Object);
            //Assert
            Assert.IsInstanceOf(typeof(Calc), calc);
            Assert.IsTrue(calc.Number1 == 3 && calc.Number2 == 6 && calc.Number3 == 34 && calc.Number4 == 100 && calc.Randomize1 == mock.Object && calc.Randomize2 == mock.Object);
        }
        #region Add
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(3, 8)).Returns(7);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(51, 88)).Returns(64);
            var calc = new Calc(3, 8, 51, 88, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Add();
            var expect = 71;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-3, -8)).Returns(-7);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-1, -3)).Returns(-2);
            var calc = new Calc(-3, -8, -1, -3, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Add();
            var expect = -9;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(3, -8)).Returns(-5);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(10, -3)).Returns(7);
            var calc = new Calc(3, -8, 10, -3, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Add();
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddNegativeAndPositiveNumbers()
        {
            var mojaLiczba = -3;
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-3, 8)).Returns(5);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-10, 3)).Returns(-7);
            var calc = new Calc(mojaLiczba, 8, -10, 3, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Add();
            var expect = -2;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion 
        #region Divide
        [Test]
        public void DivideNegativeNumbersByZero()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-3, 0)).Returns(0);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-1, 0)).Returns(0);
            var calc = new Calc(-3, 0, -1, 0, mockAddNumber1.Object, mockAddNumber2.Object);
            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]
        public void DividePositiveNumbersByZero()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(3, 0)).Returns(0);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(1, 0)).Returns(0);
            var calc = new Calc(3, 0, 1, 0, mockAddNumber1.Object, mockAddNumber2.Object);
            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]
        public void DivideTwoZeros()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(0, 0)).Returns(0);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(0, 0)).Returns(0);
            var calc = new Calc(0, 0, 0, 0, mockAddNumber1.Object, mockAddNumber2.Object);
            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide());
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-20, 2)).Returns(-10);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-10, 2)).Returns(-5);
            var calc = new Calc(-20, 2, -10, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Divide();
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(20, -2)).Returns(-10);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(10, -2)).Returns(-5);
            var calc = new Calc(20, -2, 10, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Divide();
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(20, 2)).Returns(10);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(10, 2)).Returns(5);
            var calc = new Calc(20, 2, 10, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Divide();
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-20, -2)).Returns(10);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-10, -2)).Returns(5);
            var calc = new Calc(-20, -2, -10, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Divide();
            var expect = 2;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion 
        #region Multiply
        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(10, -2)).Returns(-20);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(5, -2)).Returns(-10);
            var calc = new Calc(10, -2, 5, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Multiply();
            var expect = 200;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-10, 2)).Returns(-20);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-5, 2)).Returns(-10);
            var calc = new Calc(-10, 2, -5, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Multiply();
            var expect = 200;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(10, 2)).Returns(20);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(5, 2)).Returns(10);
            var calc = new Calc(10, 2, 5, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Multiply();
            var expect = 200;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-10, -2)).Returns(20);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-5, -2)).Returns(10);
            var calc = new Calc(-10, -2, -5, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Multiply();
            var expect = 200;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region Substruct
        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(10, -2)).Returns(12);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(5, -2)).Returns(7);
            var calc = new Calc(10, -2, 5, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Substruct();
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-10, 2)).Returns(-8);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-5, 2)).Returns(-3);
            var calc = new Calc(-10, 2, -5, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Substruct();
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(10, 2)).Returns(8);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(5, 2)).Returns(3);
            var calc = new Calc(10, 2, 5, 2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Substruct();
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            //Arrange
            var mockAddNumber1 = new Mock<IRandomize>();
            mockAddNumber1.Setup(man => man.RandomNumber(-10, -2)).Returns(-8);
            var mockAddNumber2 = new Mock<IRandomize>();
            mockAddNumber2.Setup(man => man.RandomNumber(-5, -2)).Returns(-3);
            var calc = new Calc(-10, -2, -5, -2, mockAddNumber1.Object, mockAddNumber2.Object);
            //Act
            var actual = calc.Substruct();
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
    }
}

