namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public string Convert(int number)
        {
            if (NumberIsMultipleOf3() && NumberIsMultipleOf5())
            {
                return Fizz + Buzz;
            }

            if (NumberIsMultipleOf5())
            {
                return Buzz;
            }

            if (NumberIsMultipleOf3())
            {
                return Fizz;
            }

            return number.ToString();

            bool NumberIsMultipleOf3() => number % 3 == 0;

            bool NumberIsMultipleOf5() => number % 5 == 0;
        }
    }
}