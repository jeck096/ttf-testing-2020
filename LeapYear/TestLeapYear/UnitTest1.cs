using NUnit.Framework;
using LeapYear;
namespace TestLeapYear
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        public void IsLeapYear_ShouldReturnFalse_WhenYearIsNumber(int number)
        {
            bool isLeap = LeapYears.IsLeapYear(number);

            Assert.That(isLeap, Is.False);
        }

        [TestCase(4)]
        [TestCase(8)]
        
        public void IsLeapYear_ShouldReturntrue_WhenYearIsNumber(int number)
        {
            bool isLeap = LeapYears.IsLeapYear(number);

            Assert.That(isLeap, Is.True);
        }
        [TestCase(1700)]
        public void IsLeapYear_ShouldReturnFalse_WhenYearIsSecolar(int number)
        {
            bool isLeap = LeapYears.IsLeapYear(number);

            Assert.That(isLeap, Is.False);
        }
        [TestCase(400)]
        [TestCase(100)]
        public void IsLeapYear_ShouldReturntrue_WhenYearIsSecolarFour(int number)
        {
            bool isLeap = LeapYears.IsLeapYear(number);

            Assert.That(isLeap, Is.True);
        }
        [TestCase(-4)]
        public void IsLeapYear_ShouldReturnFalse_WhenYearIsNegative(int number)
        {
            bool isLeap = LeapYears.IsLeapYear(number);

            Assert.That(isLeap, Is.False);
        }
        [Test]
        public void IsLeapYear_ShouldThrowArgumentException_WhenYearIsZero()
        {
            

            Assert.That(()=>LeapYears.IsLeapYear(0), Throws.ArgumentException);
        }
        #region old
        //[Test]
        //public void IsLeapYear_ShouldReturnFalse_WhenYearIsOne()
        //{
        //    bool isLeap = LeapYears.IsLeapYear(1);

        //    Assert.That(isLeap, Is.False);
        //}
        //[Test]
        //public void IsLeapYear_ShouldReturnFalse_WhenYearIstwo()
        //{
        //    bool isLeap = LeapYears.IsLeapYear(2);

        //    Assert.That(isLeap, Is.False);
        //}

        //[Test]
        //public void IsLeapYear_ShouldReturntrue_WhenYearIsFour()
        //{
        //    bool isLeap = LeapYears.IsLeapYear(4);

        //    Assert.That(isLeap, Is.True);
        //}
        //[Test]
        //public void IsLeapYear_ShouldReturntrue_WhenYearIsEight()
        //{
        //    bool isLeap = LeapYears.IsLeapYear(8);

        //    Assert.That(isLeap, Is.True);
        //}
        #endregion
    }
}