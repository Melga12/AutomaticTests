using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;

namespace IntegratedTests
{
    public class CalcRandomizeNumberTests
    {
        Random random;
        Randomize randomize1;
        Randomize randomize2;

        [SetUp]
        public void Setup()
        {
            random = new Random();
            randomize1 = new Randomize(random);
            randomize2 = new Randomize(random);
        }

        [Test]
        public void CheckCreateCalc()
        {
            //Arrange
            var calc = new Calc(3, 7, 25, 30, randomize1, randomize2);
            Assert.IsInstanceOf(typeof(Calc), calc);
            Assert.Pass();
        }
        #region Add
        [Test]
        public void AddTwoPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(3, 8, 11, 18, randomize1, randomize2);
            //act
            var actual = calc.Add();
            Assert.Pass();
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(-13, -8, -11, -6, randomize1, randomize2);
            //act
            var actual = calc.Add();
            Assert.Pass();
        }

        [Test]
        public void AddPositiveAndNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(3, 8, -18, -10, randomize1, randomize2);
            //act
            var actual = calc.Add();
            Assert.Pass();
        }

        [Test]
        public void AddNegativePositiveNumbers()
        {
            //Arrange
            var calc = new Calc(-8, -2, 11, 18, randomize1, randomize2);
            //act
            var actual = calc.Add();
            Assert.Pass();
        }
        [Test]
        public void AddTwoNegativeNumbers1()
        {
            //Arrange
            var randomize2 = new Mock<Randomize>();
            var calc = new Calc(-13, -8, -11, -6, randomize1, randomize2.Object);
            //act
            var actual = calc.Add();
            Assert.Pass();
        }
        #endregion
        #region Divide
        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(4, 9, 1, 3, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(-9, -5, -3, -1, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(5, 9, -3, -1, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(-9, -3, 1, 5, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DivideNegativeNumberByZero()
        {
            //Arrange
            var calc = new Calc(-9, 0, -1, 0, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DividePositiveNumberByZero()
        {
            //Arrange
            var calc = new Calc(0, 3, -1, 0, randomize1, randomize2);
            //act
            var actual = calc.Divide();
            Assert.Pass();
        }

        [Test]
        public void DivideTwoZeros()
        {
            //Arrange
            var calc = new Calc(0, 0, 0, 0, randomize1, randomize2);
            Assert.Throws<Exception>(() => calc.Divide());
        }
        #endregion
        #region Multiply
        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(1, 3, 4, 9, randomize1, randomize2);
            //act
            var actual = calc.Multiply();
            Assert.Pass();
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(-3, -1, -9, -4, randomize1, randomize2);
            //act
            var actual = calc.Multiply();
            Assert.Pass();
        }

        [Test]
        public void MultiplyNegativeAndPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(-3, -1, 1, 4, randomize1, randomize2);
            //act
            var actual = calc.Multiply();
            Assert.Pass();
        }

        [Test]
        public void MultiplyPositiveAndNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(1, 3, -4, -1, randomize1, randomize2);
            //act
            var actual = calc.Multiply();
            Assert.Pass();
        }
        #endregion
        #region Substruct
        [Test]
        public void SubstructPositiveAndNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(1, 3, -4, -1, randomize1, randomize2);
            //act
            var actual = calc.Substruct();
            Assert.Pass();
        }

        [Test]
        public void SubstructNegativeAndPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(-3, -1, 1, 4, randomize1, randomize2);
            //act
            var actual = calc.Substruct();
            Assert.Pass();
        }

        [Test]
        public void SubstructTwoPositiveNumbers()
        {
            //Arrange
            var calc = new Calc(1, 3, 4, 9, randomize1, randomize2);
            //act
            var actual = calc.Substruct();
            Assert.Pass();
        }

        [Test]
        public void SubstructTwoNegativeNumbers()
        {
            //Arrange
            var calc = new Calc(-3, -1, -9, -4, randomize1, randomize2);
            //act
            var actual = calc.Substruct();
            Assert.Pass();
        }
        #endregion
    }
}

