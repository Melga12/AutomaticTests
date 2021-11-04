using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;


namespace MyTests
{
    public class CalculatorClassTests
    {
        [Test]
        public void CheckCreateCalculatorClass()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2

            };
            //Assert
            Assert.IsInstanceOf(typeof(CalculatorClass), calculatorClass);
            Assert.IsTrue(calculatorClass.Number1 == 10 && calculatorClass.Number2 == 2);

        }
        #region add
        [Test]
        public void AddTwoPossitiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Add();
            var expect = 12;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Add();
            var expect = -12;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddPossitiveAndNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Add();
            var expect = 8;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void AddNegativeAndPossitiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Add();
            var expect = -8;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region divide
        [Test]
        public void DivideTwoZeros()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 0,
                Number2 = 0
            };
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculatorClass.Divide());
        }
        [Test]
        public void DivideNegativeNumberByZero()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 0
            };
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculatorClass.Divide());
        }

        [Test]
        public void DividePositiveNumberByZero()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 0
            };
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculatorClass.Divide());
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Divide();
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Divide();
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DividePositiveAndNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Divide();
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void DivideNegativeAndPositiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Divide();
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region multiply
        [Test]
        public void MultiplyPossitiveAAndNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Multiply();
            var expect = -20;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void MultiplyNegativeAndPossitiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Multiply();
            var expect = -20;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Multiply();
            var expect = 20;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void MultiplyTwoPosityveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Multiply();
            var expect = 20;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region substract
        [Test]
        public void CheckSubstractTwoNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Substruct();
            var expect = -8;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckSubstractTwoPositiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Substruct();
            var expect = 8;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstractPositiveAndNegativeNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = 10,
                Number2 = -2
            };
            //Act
            var actual = calculatorClass.Substruct();
            var expect = 12;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstractNegativeAndPositiveNumbers()
        {
            //Arrange 
            var calculatorClass = new CalculatorClass()
            {
                Number1 = -10,
                Number2 = 2
            };
            //Act
            var actual = calculatorClass.Substruct();
            var expect = -12;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
    }
}
