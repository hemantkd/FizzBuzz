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

            if (NumberIsMultipleOf3())
            {
                return "Fizz";
            }

            return number.ToString();

            bool NumberIsMultipleOf3()
            {
                return number % 3 == 0;
            }
        }
    }
}