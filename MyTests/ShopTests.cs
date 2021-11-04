using ApplicationToLearnTest;
using NUnit.Framework;
using System;

namespace MyTests
{
    public class ShopTests
    {
        Shop shop;

        [Test]
        public void CheckIfShopCreate()
        {
            //Arrange
            shop = new Shop();
            //Assert
            Assert.IsInstanceOf(typeof(Shop), shop);
        }

        [Test]
        public void CheckPriceLessThanTen()
        {
            //Act
            var actual = shop.CreateDiscount(1, 9);
            var expect = 0;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        #region discount 0.1

        [Test]
        public void CheckPriceEqualToTen()
        {
            //Act
            var actual = shop.CreateDiscount(1, 10);
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToEleven()
        {
            //Act
            var actual = shop.CreateDiscount(1, 11);
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToTwentyNine()
        {
            //Act
            var actual = shop.CreateDiscount(1, 29);
            var expect = 1 * 0.1;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region discount 0.15
        [Test]
        public void CheckPriceEqualToThirty()
        {
            //Act
            var actual = shop.CreateDiscount(1, 30);
            var expect = 1 * 0.15 + 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToFortyNine()
        {
            //Act
            var actual = shop.CreateDiscount(1, 49);
            var expect = 1 * 0.15 + 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region discount 0.2
        [Test]
        public void CheckPriceEqualToFifty()
        {
            //Act
            var actual = shop.CreateDiscount(1, 50);
            var expect = 1 * 0.2 + 10;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToNinetyNine()
        {
            //Act
            var actual = shop.CreateDiscount(1, 99);
            var expect = 1 * 0.2 + 10;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion
        #region discount 0.25
        [Test]
        public void CheckPriceEqualToOneHundred()
        {
            //Act
            var actual = shop.CreateDiscount(1, 100);
            var expect = 1 * 0.25 + 15;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckPriceEqualToOneThousand()
        {
            //Act
            var actual = shop.CreateDiscount(1, 1000);
            var expect = 1 * 0.25 + 15;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        #endregion

        [Test]
        public void CheckQuantityMoreThanPrice()
        {
            //Act
            var actual = shop.CreateDiscount(1000, 101);
            var expect = 265;
            //Assert
            Assert.AreEqual(expect, actual);
        }


    }
}
