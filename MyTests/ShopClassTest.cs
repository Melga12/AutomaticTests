using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;


namespace MyTests
{
    public class ShopClassTests
    {
        [Test]
        public void CheckCreateShopClass()
        {
            //Arrange
            var shopClass = new ShopClass(1, 9);

            //Assert
            Assert.IsInstanceOf(typeof(ShopClass), shopClass);
            Assert.IsTrue(shopClass.Quantity == 1 && shopClass.Price == 9);
        }

        [Test]
        public void CheckPriceLessThanTen()
        {
            //Arrange
            var shopClass = new ShopClass(1, 9);

            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 0;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #region discount 0.1
        [Test]
        public void CheckPriceEqualToTen()
        {
            //Arrange
            var shopClass = new ShopClass(1, 10);
          
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToEleven()
        {
            //Arrange
            var shopClass = new ShopClass(1, 11)
            {
                Quantity = 1,
                Price = 11
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToTwentyNine()
        {
            //Arrange
            var shopClass = new ShopClass(1, 29)
            {
                Quantity = 1,
                Price = 29
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region discount 0.15
        [Test]
        public void CheckPriceEqualToThirty()
        {
            //Arrange
            var shopClass = new ShopClass(1, 30)
            {
                Quantity = 1,
                Price = 30
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.15 + 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckPriceEqualToFortyNine()
        {
            //Arrange
            var shopClass = new ShopClass(1, 49)
            {
                Quantity = 1,
                Price = 49
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.15 + 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region discount 0.2
        [Test]
        public void CheckPriceEqualToFifty()
        {
            //Arrange
            var shopClass = new ShopClass(1, 50)
            {
                Quantity = 1,
                Price = 50
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.2 + 10;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckPriceEqualToNinetyNine()
        {
            //Arrange
            var shopClass = new ShopClass(1, 99)
            {
                Quantity = 1,
                Price = 99
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.2 + 10;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion

        [Test]
        public void CheckPriceEqualToOneHundred()
        {
            //Arrange
            var shopClass = new ShopClass(1, 100)
            {
                Quantity = 1,
                Price = 100
            };
            //Act
            var actual = shopClass.CreateDiscount();
            var expect = 1 * 0.25 + 15;
            //Assert
            Assert.AreEqual(expect, actual);
        }

    }
}