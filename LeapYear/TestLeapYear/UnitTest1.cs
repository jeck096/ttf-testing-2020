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
    }
}