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
        public void One_ShouldReturn_NoPreimeFactors()
        {
            List<int> primeFactor = PrimeFactor.Calculate(1);
            Assert.That(primeFactor, Is.Empty);
            Assert.Pass();
        }
    }
}