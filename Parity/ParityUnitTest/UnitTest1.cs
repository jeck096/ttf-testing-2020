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
        [TestCase(5)]
        [TestCase(381725981)]
        [TestCase(-13)]
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

        //[Test]
        //public void IsEven_ShouldReturnFalse_WhenNumerIsTwo()
        //{
        //    bool isEven = ParityService.IsEven(2);
        //    Assert.That(isEven, Is.False);
        //}
        #endregion

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(875901452)]
        [TestCase(-10)]
        [TestCase(0)]
        public void IsEven_ShouldReturnFalse_WhenNumerIsPair(int number)
        {
            bool isEven = ParityService.IsEven(number);
            Assert.That(isEven, Is.False);
        }


        [Test]
        public void IsOdd_ShouldReturnFalse_WhenNumerIsNotDivisibleByTwo()
        {
            bool isOdd = ParityService.IsOdd(1);
            Assert.That(isOdd, Is.False);
        }


        [Test]
        public void IsOdd_ShouldReturnTrue_WhenNumerIsDivisibleByTwo()
        {
            bool isOdd = ParityService.IsOdd(2);
            Assert.That(isOdd, Is.True);
        }

    }
}