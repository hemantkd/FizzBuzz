using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,"Fizz")]
        [TestCase(4,"4")]
        [TestCase(7,"7")]
        [TestCase(8,"8")]
        [TestCase(11,"11")]
        [TestCase(13,"13")]
        [TestCase(14,"14")]
        public void Convert_number_to_fizzbuzz_string(int number, string expectedOutput)
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(number);

            // Assert
            Assert.That(actualValue, Is.EqualTo(expectedOutput));
        }
    }
}