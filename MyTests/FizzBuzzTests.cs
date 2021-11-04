using ApplicationToLearnTest;
using NUnit.Framework;
using System;

namespace MyTests
{
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;

        [SetUp]
        public void CheckIfFizzBuzzCreate()
        {
            //Arrange
            fizzBuzz = new FizzBuzz();
            //Assert
            Assert.IsInstanceOf(typeof(FizzBuzz), fizzBuzz);
        }
        #region DivideByThreeAndFive
        [Test]
        public void DividePostiveNumberByThreeAndFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(15);
            var expect = "FizzBuzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeveNumberByThreeAndFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-15);
            var expect = "FizzBuzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckcheckPositiveNumberIndivisibleByThreeandFive()
        {
            //Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(11));
        }

        [Test]
        public void CheckcheckNegativeNumberIndivisibleByThreeandFive()
        {
            //Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(-11));
        }
        #endregion
        #region DivideByThree
        [Test]
        public void DividePostiveNumberByThree()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(6);
            var expect = "Fizz";
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeNumberByThree()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-6);
            var expect = "Fizz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region DivideByFive
        [Test]
        public void DividePostiveNumberByFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(10);
            var expect = "Buzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeNumberByFive()
        {
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-10);
            var expect = "Buzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
    }
}

