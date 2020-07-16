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

        [TestCase("1")]
        public void InsertStringNumber_ReturnNumber(string input)
        {
            int number = StringModel.Add(input);
            int verifica = int.Parse(input);
            Assert.That(number, Is.EqualTo(verifica));
        }
    }
}