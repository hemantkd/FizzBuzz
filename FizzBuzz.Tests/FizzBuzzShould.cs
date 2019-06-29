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
    }
}