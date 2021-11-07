using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace IntegratedTests
{
    public class PassRandomize
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCreatePass()
        {
            //Arrange
            var random = new Random();
            var randomize = new Randomize(random);
            var pass = new Pass(randomize, true, true, 1, 2);
            Assert.IsInstanceOf(typeof(Pass), pass);
            Assert.Pass();
        }
    }
}









