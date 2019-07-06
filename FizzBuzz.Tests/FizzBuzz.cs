namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
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