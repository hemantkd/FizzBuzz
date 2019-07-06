namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            if (NumberIsMultipleOf5())
            {
                return "Buzz";
            }

            if (NumberIsMultipleOf3())
            {
                return "Fizz";
            }

            return number.ToString();

            bool NumberIsMultipleOf3() => number % 3 == 0;

            bool NumberIsMultipleOf5() => number % 5 == 0;
        }
    }
}