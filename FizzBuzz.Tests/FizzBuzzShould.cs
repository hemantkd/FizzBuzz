using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4,"4")]
        [TestCase(7,"7")]
        [TestCase(8,"8")]
        [TestCase(11,"11")]
        [TestCase(13,"13")]
        [TestCase(14,"14")]
        public void Convert_regular_number_to_number_string(int number, string expectedOutput)
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(number);

            // Assert
            Assert.That(actualValue, Is.EqualTo(expectedOutput));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Convert_multiples_of_3_to_Fizz(int number)
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(number);

            // Assert
            Assert.That(actualValue, Is.EqualTo(FizzBuzzConstants.Fizz));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(40)]
        public void Convert_multiples_of_5_to_Buzz(int number)
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(number);

            // Assert
            Assert.That(actualValue, Is.EqualTo(FizzBuzzConstants.Buzz));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Convert_multiples_of_3_and_5_to_Buzz(int number)
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(number);

            // Assert
            Assert.That(actualValue, Is.EqualTo(FizzBuzzConstants.Fizz+FizzBuzzConstants.Buzz));
        }
    }
}