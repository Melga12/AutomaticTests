using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;


namespace MyTests
{
    class PersonalityTests
    {
        [Test]
        public void CheckCreatePersonality()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("Wykonawca");
            var personality = new Personality(mock.Object, true, true, true, true);
            Assert.IsInstanceOf(typeof(Personality), personality);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == true && personality.Judging == true);
        }

        [Test]
        public void CheckArchitekt()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("Architekt");
            var personality = new Personality(mock.Object, false, false, true, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == true && personality.Judging == true);
        }

        [Test]
        public void CheckLogik()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, false)).Returns("Logik");
            var personality = new Personality(mock.Object, false, false, true, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == true && personality.Judging == false);
        }

        [Test]
        public void CheckDowódca()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, true, true)).Returns("Dowódca");
            var personality = new Personality(mock.Object, true, false, true, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == true && personality.Judging == true);
        }

        [Test]
        public void CheckDyskutant()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, true, false)).Returns("Dyskutant");
            var personality = new Personality(mock.Object, true, false, true, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == true && personality.Judging == false);
        }

        [Test]
        public void CheckRzecznik()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, true)).Returns("Rzecznik");
            var personality = new Personality(mock.Object, false, false, false, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == false && personality.Judging == true);
        }

        [Test]
        public void CheckPośrednik()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, false)).Returns("Pośrednik");
            var personality = new Personality(mock.Object, false, false, false, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == false && personality.Thinking == false && personality.Judging == false);
        }

        [Test]
        public void CheckProtagonista()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, true)).Returns("Protagonista");
            var personality = new Personality(mock.Object, true, false, false, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == false && personality.Judging == true);
        }

        [Test]
        public void CheckDziałacz()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, false)).Returns("Działacz");
            var personality = new Personality(mock.Object, true, false, false, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == false && personality.Thinking == false && personality.Judging == false);
        }

        [Test]
        public void CheckLogistyk()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, true)).Returns("Logistyk");
            var personality = new Personality(mock.Object, false, true, true, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == true && personality.Judging == true);
        }

        [Test]
        public void CheckObrońca()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, true)).Returns("Obrońca");
            var personality = new Personality(mock.Object, false, true, false, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == false && personality.Judging == true);
        }

        [Test]
        public void CheckPersonalityWykonawca()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("Wykonawca");
            var personality = new Personality(mock.Object, true, true, true, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == true && personality.Judging == true);
        }

        [Test]
        public void CheckDoradca()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, true)).Returns("Doradca");
            var personality = new Personality(mock.Object, true, true, false, true);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == false && personality.Judging == true);
        }

        [Test]
        public void CheckWirtuoz()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, false)).Returns("Wirtuoz");
            var personality = new Personality(mock.Object, false, true, true, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == true && personality.Judging == false);
        }

        [Test]
        public void CheckPoszukiwaczPrzygód()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, false)).Returns("PoszukiwaczPrzygód");
            var personality = new Personality(mock.Object, false, true, false, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == false && personality.Sensing == true && personality.Thinking == false && personality.Judging == false);
        }

        [Test]
        public void CheckPrzedsiębiorca()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, false)).Returns("Przedsiębiorca");
            var personality = new Personality(mock.Object, true, true, true, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == true && personality.Judging == false);
        }

        [Test]
        public void CheckAnimator()
        {
            //Arrange
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("Animator");
            var personality = new Personality(mock.Object, true, true, false, false);
            Assert.IsTrue(personality._code == mock.Object && personality.Extraversion == true && personality.Sensing == true && personality.Thinking == false && personality.Judging == false);
        }
    }
}





