using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace MyTests
{
    public class RandomizeTests
    {
        Random random;
        Randomize randomize;

        [SetUp]
        public void SetUp()
        {
            random = new Random();
            randomize = new Randomize(random);
        }

        [Test]
        public void CheckCreateRandomize()
        {
            //Assert
            Assert.IsInstanceOf(typeof(Randomize), randomize);
            Assert.IsTrue(randomize._random == random);
        }
        #region RandomNumber

        [Test]
        public void CheckRandomizeTwoPositiveNumbersRange()
        {
            //Act
            var actual = randomize.RandomNumber(2, 11);
            //Assert
            Assert.IsTrue(actual >= 2 && actual < 11);
        }

        [Test]
        public void CheckRandomizeTwoNegativeNumbersRange()
        {
            //Act
            var actual = randomize.RandomNumber(-5, -1);
            //Assert
            Assert.IsTrue(actual >= -5 && actual < -1);
        }

        [Test]
        public void CheckRandomizeNegativeAndPositiveNumbersRange()
        {
            //Act
            var actual = randomize.RandomNumber(-20, 40);
            //Assert
            Assert.IsTrue(actual >= -20 && actual < 40);
        }

        [Test]
        public void CheckRandomizePositiveAndNegativeNumbersRange()
        {
            //Arrange
            var random = new Random();
            var randomize = new Randomize(random);
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomNumber(5, -10));
        }
        #endregion
        #region RandomString

        [Test]
        public void CheckSmallLetters()
        {
            //Act
            var actual = randomize.RandomString(6, true);
            //Assert
            Assert.IsTrue(actual.Length == 6 && actual.All(char.IsLower));
        }

        [Test]
        public void CheckWithoutSmallLetters()
        {
            //Act
            var actual = randomize.RandomString(3, false);
            //Assert
            Assert.IsTrue(actual.Length == 3 && !actual.All(char.IsLower));
        }

        [Test]
        public void CheckSizeLessZero()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomString(-1, true));
        }
        #endregion
        #region RandomPassword
        [Test]
        public void CheckPasswordWithNumber()
        {
            //Act
            var actual = randomize.RandomPassword(true, false, 0, 0);
            //Assert
            Assert.IsTrue(actual.Length == 1 && actual.All(char.IsDigit));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacters()
        {
            //Act
            var actual = randomize.RandomPassword(false, true, 0, 0);
            //Assert
            Assert.IsTrue(actual.Length == 1 && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithSmallLetters()
        {
            //Act
            var actual = randomize.RandomPassword(false, false, 2, 0);
            //Assert
            Assert.IsTrue(actual.Length == 2 && actual.All(char.IsLower));
        }

        [Test]
        public void CheckPasswordWithBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(false, false, 0, 1);
            //Assert
            Assert.IsTrue(actual.Length == 1 && actual.All(char.IsUpper));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterSmallLettersBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 2, 1);
            //Assert
            Assert.IsTrue(actual.Length == 5 && actual.Any(char.IsLower) && actual.Any(char.IsUpper) && actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithNumberAndSpecialCharacter()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 0, 0);
            //Assert
            Assert.IsTrue(actual.Length == 2 && actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithNumberAndSmallLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, false, 3, 0);
            //Assert
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsLower) && actual.Any(char.IsDigit));
        }

        [Test]
        public void CheckPasswordWithNumberAndBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, false, 0, 4);
            //Assert
            Assert.IsTrue(actual.Length == 5 && actual.Any(char.IsUpper) && actual.Any(char.IsDigit));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterAndSmallLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 2, 0);
            //Assert
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsLower) && actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterAndBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(true, true, 0, 5);
            //Assert
            Assert.IsTrue(actual.Length == 7 && actual.Any(char.IsUpper) && actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithoutSpecialCharacter()
        {
            //Act
            var actual = randomize.RandomPassword(true, false, 2, 1);
            //Assert
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsLower) && actual.Any(char.IsUpper) && actual.Any(char.IsDigit) && actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithoutNumber()
        {
            //Act
            var actual = randomize.RandomPassword(false, true, 2, 1);
            //Assert
            Assert.IsTrue(actual.Length == 4 && actual.Any(char.IsLower) && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithoutNumberAndSmallLetters()
        {
            //Act
            var actual = randomize.RandomPassword(false, true, 0, 1);
            //Assert
            Assert.IsTrue(actual.Length == 2 && actual.Any(char.IsUpper) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithoutNumberAndBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(false, true, 4, 0);
            //Assert
            Assert.IsTrue(actual.Length == 5 && actual.Any(char.IsLower) && !actual.All(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithoutNumberAndSpecialCharacter()
        {
            //Act
            var actual = randomize.RandomPassword(false, false, 2, 1);
            //Assert
            Assert.IsTrue(actual.Length == 3 && actual.Any(char.IsLower) && actual.Any(char.IsUpper));
        }

        [Test]
        public void CheckPasswordWithoutNumberSpecialCharacterSmallLettersBigLetters()
        {
            //Act
            var actual = randomize.RandomPassword(false, false, 0, 0);
            //Assert
            Assert.IsTrue(actual.Length == 0 && !actual.Any(char.IsLower) && !actual.Any(char.IsUpper) && !actual.Any(char.IsDigit) && !actual.Any(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthSmallLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -1, 0));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, 0, -1));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthsSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -1, -1));
        }

        [Test]
        public void CheckPasswordWithNegativeLengthSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -1, 1));
        }

        [Test]
        public void CheckPasswordWithSmallLettersAndNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, 1, -1));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterNegativeLengthsSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, -1, -1));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterNegativeLengthSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, -1, 1));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterSmallLettersAndNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, 1, -1));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterNegativeLengthsSmallLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, -1, 0));
        }

        [Test]
        public void CheckPasswordWithNumberSpecialCharacterNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, 0, -1));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacterNegativeLengthsSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, -1, -1));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacterNegativeLengthSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, -1, 1));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacterSmallLettersAndNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, 1, -1));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacterNegativeLengthsSmallLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, -1, 0));
        }

        [Test]
        public void CheckPasswordWithSpecialCharacterNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, 0, -1));
        }

        [Test]
        public void CheckPasswordWithNumberNegativeLengthsSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, -1, -1));
        }

        [Test]
        public void CheckPasswordWithNumberNegativeLengthSmallAndBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, -1, 1));
        }

        [Test]
        public void CheckPasswordWithNumberSmallLettersAndNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, 1, -1));
        }

        [Test]
        public void CheckPasswordWithNumberNegativeLengthsSmallLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, -1, 0));
        }

        [Test]
        public void CheckPasswordWithNumberNegativeLengthBigLetters()
        {
            //Assert
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, 0, -1));
        }
        #endregion
    }
}



