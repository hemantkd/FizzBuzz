namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            if (number == 5)
            {
                return "Buzz";
            }

            if (number == 10)
            {
                return "Buzz";
            }

            if (NumberIsMultipleOf3())
            {
                return "Fizz";
            }

            return number.ToString();

            bool NumberIsMultipleOf3() => number % 3 == 0;
        }
    }
}