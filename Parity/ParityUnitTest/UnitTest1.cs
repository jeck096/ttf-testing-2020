using NUnit.Framework;
using Parity;
namespace ParityUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(1)]
        [TestCase(3)]
        public void IsEven_ShouldReturnTrue_WhenNumerIsEven(int number)
        {
            bool isEven = ParityService.IsEven(number);

            Assert.That(isEven, Is.True);

        }
        #region Old
        //[Test]
        //public void IsEven_ShouldReturnTrue_WhenNumerIsOne()
        //{
        //    bool isEven = ParityService.IsEven(1);

        //    Assert.That(isEven, Is.True);

        //}

        //[Test]
        //public void IsEven_ShouldReturnFalse_WhenNumerIsThree()
        //{
        //    bool isEven = ParityService.IsEven(3);
        //    Assert.That(isEven, Is.True);
        //}
        #endregion

        [Test]
        public void IsEven_ShouldReturnFalse_WhenNumerIsTwo()
        {
            bool isEven = ParityService.IsEven(2);
            Assert.That(isEven, Is.False);
        }


    }
}