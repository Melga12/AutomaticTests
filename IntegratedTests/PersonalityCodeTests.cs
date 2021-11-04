using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace IntegratedTests
{
    public class PersonalityCodeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCreatePersonality()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, true, false, false);
            //Assert
            Assert.IsInstanceOf(typeof(Personality), personality);
            Assert.Pass();
        }

        [Test]
        public void CheckCreateArchitekt()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, false, true, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Architekt";
            //Assert
            Assert.AreEqual(actual, expect);
            Assert.Pass();
        }

        [Test]
        public void CheckCreateLogik()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, false, true, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Logik";
            //Assert
            Assert.AreEqual(actual, expect);
            Assert.Pass();
        }

        [Test]
        public void CheckCreateDowódca()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, false, true, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Dowódca";
            //Assert
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == true && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateDyskutant()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, false, true, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Dyskutant";
            //Assert
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == true && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateRzecznik()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, false, false, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Rzecznik";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == false && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreatePośrednik()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, false, false, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Pośrednik";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == false && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateProtagonista()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, false, false, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Protagonista";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == false && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateDziałacz()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, false, false, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Działacz";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == false && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateLogistyk()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, true, true, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Logistyk";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == true && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateObrońca()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, true, false, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Obrońca";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == false && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateWykonawca()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, true, true, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Wykonawca";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == true && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateDoradca()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, true, false, true);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Doradca";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == false && personality.Judging == true);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateWirtuoz()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, true, true, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Wirtuoz";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == true && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreatePoszukiwaczPrzygód()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, false, true, false, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Poszukiwacz przygód";
            Assert.IsTrue(personality._code == code && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == false && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreatePrzedsiębiorca()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, true, true, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Przedsiębiorca";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == true && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckCreateAnimator()
        {
            //Arrange
            var code = new Code();
            var personality = new Personality(code, true, true, false, false);
            //Act
            var actual = personality.GetPersonality();
            var expect = "Animator";
            Assert.IsTrue(personality._code == code && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == false && personality.Judging == false);
            Assert.AreEqual(actual, expect);
        }
    }
}


