using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;
using Moq;


namespace MyTests
{
    public class PassTests
    {
        [Test]
        public void CheckCreatePass()
        {
            //Arrange
            var mock = new Mock<IRandomize>();
            var pass = new Pass(mock.Object, true, true, 1, 2);
            Assert.IsInstanceOf(typeof(Pass), pass);
            Assert.IsTrue(pass._randomize == mock.Object && pass.Numbers == true && pass.SpecialCharacter == true && pass.SmallLetters == 1 && pass.BigLetters == 2);
        }
    }


}

