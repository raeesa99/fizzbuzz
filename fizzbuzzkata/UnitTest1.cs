namespace fizzbuzzkata
{
    public class FizzBuzz
    {
        [Fact]
        public void IntReturnsInt()
        {
            var result = check(1);
            Assert.Equal("1", result);
        }
        [Fact]
        public void IntIsDivisibleBy3() {
            var result = check(3);
            Assert.Equal("Fizz", result);
        }
        public string check(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}