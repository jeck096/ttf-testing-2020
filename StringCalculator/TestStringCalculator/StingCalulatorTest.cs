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
        public void InsertStringTwoNumbers_ReturnSumNumber(string input, int risultato)
        {
            int number = StringModel.Add(input);
           
            Assert.That(number, Is.EqualTo(risultato));
        }
        [TestCase("1,2,5,6,7,8", 1+2+5+6+7+8)]
        [TestCase("31651,26646541,54561,6548648,70000,438", 31651 + 26646541 + 54561 + 6548648 + 70000 + 438)]
        public void InsertStringNumbers_ReturnSumNumbers(string input, int risultato)
        {
            int number = StringModel.Add(input);

            Assert.That(number, Is.EqualTo(risultato));
        }
        [TestCase("1,2,5\n6,7,8", 1 + 2 + 5 + 6 + 7 + 8)]
        public void InsertNewLineSeparator_ReturnSumNumbers(string input, int risultato)
        {
            int number = StringModel.Add(input);

            Assert.That(number, Is.EqualTo(risultato));
        }
        [TestCase("//;\n1;2;5;6;7;8", 1 + 2 + 5 + 6 + 7 + 8)]
        public void InsertCostumSeparator_ReturnSumNumbers(string input, int risultato)
        {
            int number = StringModel.Add(input);

            Assert.That(number, Is.EqualTo(risultato));
        }
    }
}