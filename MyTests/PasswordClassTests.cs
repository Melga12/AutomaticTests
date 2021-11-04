using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace MyTests
{
    public class PasswordClassTests
    {
        [Test]
        public void CheckCreatePasswordClass()
        {
            //Arrange 
            var passwordClass = new PasswordClass();
            //Assert
            Assert.IsInstanceOf(typeof(PasswordClass), passwordClass);

        }

        [Test]
        public void CheckRegexValidPassword()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Meg1234!"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckRegexSevenCharacters()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Meg123!"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutSpecialNumber()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Meg1234"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutNumber()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Mega@^#!"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutCapital()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "mega123!"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void CheckRegexWithoutLowercase()
        {
            //Arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "MEG123!"
            };
            //Act
            var actual = passwordClass.CheckPassword();
            //Assert
            Assert.IsFalse(actual);
        }
    }
}

