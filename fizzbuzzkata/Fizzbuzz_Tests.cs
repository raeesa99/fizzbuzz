namespace fizzbuzzkata
{
    public class FizzBuzzTests
    {      
        [Theory]
        [InlineData(1,"1")]
        [InlineData(3,"Fizz")]
        [InlineData(5,"Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzKata(int number,string expected)
        {
            var result = new FizzBuzz().Check(number);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void FizzBuzzKata_()
        {
            var input = Enumerable.Range(1, 20).ToArray();
            var result = new FizzBuzz().Check(input);
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz", result);
        }
    }
}