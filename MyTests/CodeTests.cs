using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;


namespace MyTests
{
    public class CodeTests
    {
        Code code;

        [Test]
        public void CheckCreateCode()
        {
            //Arrange
            code = new Code();
            Assert.IsInstanceOf(typeof(Code), code);
        }

        [Test]
        public void CheckENFP()
        {
            //Act
            var actual = code.GenerateCode(true, false, false, false);
            var expect = "ENFP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckENFJ()
        {
            //Act
            var actual = code.GenerateCode(true, false, false, true);
            var expect = "ENFJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckENTP()
        {
            //Act
            var actual = code.GenerateCode(true, false, true, false);
            var expect = "ENTP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckESFP()
        {
            //Act
            var actual = code.GenerateCode(true, true, false, false);
            var expect = "ESFP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckESFJ()
        {
            //Act
            var actual = code.GenerateCode(true, true, false, true);
            var expect = "ESFJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckESTP()
        {
            //Act
            var actual = code.GenerateCode(true, true, true, false);
            var expect = "ESTP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckESTJ()
        {
            //Act
            var actual = code.GenerateCode(true, true, true, true);
            var expect = "ESTJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckENTJ()
        {
            //Act
            var actual = code.GenerateCode(true, false, true, true);
            var expect = "ENTJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckINFP()
        {
            //Act
            var actual = code.GenerateCode(false, false, false, false);
            var expect = "INFP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckINFJ()
        {
            //Act
            var actual = code.GenerateCode(false, false, false, true);
            var expect = "INFJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckISTJ()
        {
            //Act
            var actual = code.GenerateCode(false, true, true, true);
            var expect = "ISTJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckINTP()
        {
            //Act
            var actual = code.GenerateCode(false, false, true, false);
            var expect = "INTP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckISFP()
        {
            //Act
            var actual = code.GenerateCode(false, true, false, false);
            var expect = "ISFP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckISFJ()
        {
            //Act
            var actual = code.GenerateCode(false, true, false, true);
            var expect = "ISFJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckISTP()
        {
            //Act
            var actual = code.GenerateCode(false, true, true, false);
            var expect = "ISTP";
            //Assert
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CheckINTJ()
        {
            //Act
            var actual = code.GenerateCode(false, false, true, true);
            var expect = "INTJ";
            //Assert
            Assert.AreEqual(actual, expect);
        }
    }

}



