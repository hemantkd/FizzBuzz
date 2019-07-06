using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,FizzBuzzConstants.Fizz)]
        [TestCase(4,"4")]
        [TestCase(5,FizzBuzzConstants.Buzz)]
        [TestCase(6,FizzBuzzConstants.Fizz)]
        [TestCase(7,"7")]
        [TestCase(8,"8")]
        [TestCase(9,FizzBuzzConstants.Fizz)]
        [TestCase(10,FizzBuzzConstants.Buzz)]
        [TestCase(11,"11")]
        [TestCase(12,FizzBuzzConstants.Fizz)]
        [TestCase(13,"13")]
        [TestCase(14,"14")]
        [TestCase(15,FizzBuzzConstants.Fizz+FizzBuzzConstants.Buzz)]
        [TestCase(20,FizzBuzzConstants.Buzz)]
        [TestCase(30,FizzBuzzConstants.Fizz+FizzBuzzConstants.Buzz)]
        [TestCase(40,FizzBuzzConstants.Buzz)]
        [TestCase(45,FizzBuzzConstants.Fizz+FizzBuzzConstants.Buzz)]
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