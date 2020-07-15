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

       



        [Test]
        public void IsLeapYear_ShouldReturnFalse_WhenYearIsOne()
        {
            bool isLeap = LeapYears.IsLeapYear(1);

            Assert.That(isLeap, Is.False);
        }
        [Test]
        public void IsLeapYear_ShouldReturnFalse_WhenYearIstwo()
        {
            bool isLeap = LeapYears.IsLeapYear(2);

            Assert.That(isLeap, Is.False);
        }

        [Test]
        public void IsLeapYear_ShouldReturntrue_WhenYearIsFour()
        {
            bool isLeap = LeapYears.IsLeapYear(4);

            Assert.That(isLeap, Is.True);
        }
        [Test]
        public void IsLeapYear_ShouldReturntrue_WhenYearIsEight()
        {
            bool isLeap = LeapYears.IsLeapYear(8);

            Assert.That(isLeap, Is.True);
        }
    }
}