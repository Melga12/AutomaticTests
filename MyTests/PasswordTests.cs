using ApplicationToLearnTest;
using NUnit.Framework;
using System;

namespace MyTests
{
    public class PasswordTests
    {
        Password password;

        [Test]
        public void CheckIfPasswordCreate()
        {
            //Arrange
            password = new Password();
            //Assert
            Assert.IsInstanceOf(typeof(Password), password);
        }

        [Test]
        public void CheckRegexValidPassword()
        {
            //Arrange
           var password = new Password();
            //Act
            var actual = password.CheckPassword("Megggg4!");
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckRegexValidSevenCharacters()
        {
            //Arrange
            var password = new Password();
            //Act
            var actual = password.CheckPassword("Meg123!");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutSpecialNumber()
        {
            //Arrange
            var password = new Password();
            //Act
            var actual = password.CheckPassword("Mega1234");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutNumber()
        {
            //Arrange
            var password = new Password();
            //Act
            var actual = password.CheckPassword("Megae@!^");
            //Assert
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckRegexWithoutCapital()
        {
            //Arrange
            var password = new Password();
            //Act
            var actual = password.CheckPassword("meg123!4");
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutLowercase()
        {
            //Arrange
            var password = new Password();
            //Act
            var actual = password.CheckPassword("MEG1234!");
            //Assert
            Assert.IsFalse(actual);
        }


    }
}
