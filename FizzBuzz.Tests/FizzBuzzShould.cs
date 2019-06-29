using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [Test]
        public void Convert_1_to_1()
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(1);

            // Assert
            Assert.That(actualValue, Is.EqualTo("1"));
        }

        [Test]
        public void Convert_2_to_2()
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(2);

            // Assert
            Assert.That(actualValue, Is.EqualTo("2"));
        }

        [Test]
        public void Convert_4_to_4()
        {
            // Arrange
            var fizzbuzz = new FizzBuzz();

            // Act
            var actualValue = fizzbuzz.Convert(4);

            // Assert
            Assert.That(actualValue, Is.EqualTo("4"));
        }
    }
}