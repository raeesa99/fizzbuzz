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
            var result = new FizzBuzz().check(number);
            Assert.Equal(expected, result);
        }


    }
}