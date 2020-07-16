using NUnit.Framework;
using StringCalculator;
namespace TestStringCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertEmpyString_ReturnZero()
        {
            int number = StringModel.Add("");

            Assert.That(number,Is.EqualTo(0));
        }

        [TestCase("1",1)]
        [TestCase("50",50)]
        public void InsertStringNumber_ReturnNumber(string input, int risultato)
        {
            int number = StringModel.Add(input);
           
            Assert.That(number, Is.EqualTo(risultato));
        }
        [TestCase("1,2",3)]
        public void InsertStringNumbers_ReturnSumNumber(string input, int risultato)
        {
            int number = StringModel.Add(input);
           
            Assert.That(number, Is.EqualTo(risultato));
        }

    }
}