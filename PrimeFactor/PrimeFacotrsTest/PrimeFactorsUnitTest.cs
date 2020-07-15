using System;
using System.Collections.Generic;
using System.Linq;
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
        [TestCase(2,2)]
        [TestCase(3, 3)]
        [TestCase(4, 2,2)]
        [TestCase(5, 5)]
        [TestCase(6, 2,3)]
        [TestCase(8, 2, 2, 2)]
        [TestCase(8, 2, 2, 2)]
        [TestCase(2*2*2*2*2*3*3*3*3*3*5*7*19, 2, 2, 2, 2, 2,3,3,3,3,3,5,7,19)]
        
        public void PrimeFactor_ShouldReturn(int number, params int[] expectedFacotrs )
        {
            List<int> primeFactor = PrimeFactor.Calculate(number);
 
            Assert.That(primeFactor, Is.EqualTo(expectedFacotrs));
            Assert.Pass();
        }
        [Test]
        public void NegativeNumber_shouldThrow_InvalidOperationExexcepition()
        {
            try
            {
                List<int> primeFactor = PrimeFactor.Calculate(-1);
            }
            catch (InvalidOperationException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [Test]
        public void ZeroNumber_shouldThrow_InvalidOperationExexcepition()
        {
            Assert.That(()=>PrimeFactor.Calculate(0), Throws.InvalidOperationException);
        }

        #region old
        //[Test]
        //public void Two_ShouldReturn_Two()
        //{
        //    List<int> primeFactor = PrimeFactor.Calculate(2);
        //    List<int> expectedValue = new List<int>() { 2 };
        //    Assert.That(primeFactor, Is.EqualTo(expectedValue));
        //    Assert.Pass();
        //}
        //[Test]
        //public void Two_ShouldReturn_Three()
        //{
        //    List<int> primeFactor = PrimeFactor.Calculate(3);
        //    List<int> expectedValue = new List<int>() { 3 };
        //    Assert.That(primeFactor, Is.EqualTo(expectedValue));
        //    Assert.Pass();
        //}
        //[Test]
        //public void Two_ShouldReturn_TwoTwo()
        //{
        //    List<int> primeFactor = PrimeFactor.Calculate(4);
        //    List<int> expectedValue = new List<int>() { 2, 2 };
        //    Assert.That(primeFactor, Is.EqualTo(expectedValue));
        //    Assert.Pass();
        //}
        #endregion
    }
}