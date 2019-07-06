namespace FizzBuzz.Tests
{
    public class FizzBuzz
    {
        public string Convert(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}