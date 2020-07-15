using System.Collections.Generic;
using NUnit.Framework;
using PrimeFactors;

namespace PrimeFacotrsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void One_ShouldReturn_NoPrimeFactors()
        {
            List<int> primeFactor = PrimeFactor.Calculate(1);
            Assert.That(primeFactor, Is.Empty);
            Assert.Pass();
        }
        [Test]
        public void Two_ShouldReturn_Two()
        {
            List<int> primeFactor = PrimeFactor.Calculate(2);
            List<int> expectedValue = new List<int>() { 2 };
            Assert.That(primeFactor, Is.EqualTo(expectedValue));
            Assert.Pass();
        }
        [Test]
        public void Two_ShouldReturn_Three()
        {
            List<int> primeFactor = PrimeFactor.Calculate(3);
            List<int> expectedValue = new List<int>() { 3 };
            Assert.That(primeFactor, Is.EqualTo(expectedValue));
            Assert.Pass();
        }
        [Test]
        public void Two_ShouldReturn_TwoFour()
        {
            List<int> primeFactor = PrimeFactor.Calculate(4);
            List<int> expectedValue = new List<int>() { 2, 2 };
            Assert.That(primeFactor, Is.EqualTo(expectedValue));
            Assert.Pass();
        }
    }
}