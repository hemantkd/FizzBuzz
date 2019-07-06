namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            if (NumberIsMultipleOf3() && NumberIsMultipleOf5())
            {
                return FizzBuzzConstants.Fizz + FizzBuzzConstants.Buzz;
            }

            if (NumberIsMultipleOf5())
            {
                return FizzBuzzConstants.Buzz;
            }

            if (NumberIsMultipleOf3())
            {
                return FizzBuzzConstants.Fizz;
            }

            return number.ToString();

            bool NumberIsMultipleOf3() => number % 3 == 0;

            bool NumberIsMultipleOf5() => number % 5 == 0;
        }
    }
}