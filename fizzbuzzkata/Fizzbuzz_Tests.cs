namespace fizzbuzzkata
{
    public class FizzBuzzTests
    {
        [Fact]
        public void IntReturnsInt()
        {
            var result = new FizzBuzz().check(1);
            Assert.Equal("1", result);
        }
        [Fact]
        public void IntIsDivisibleBy3() {
            var result = new FizzBuzz().check(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void IntIsDivisibleBy5()
        {
            var result = new FizzBuzz().check(5);
            Assert.Equal("Buzz", result);
        }
      
    }
}