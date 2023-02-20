namespace fizzbuzzkata
{
    public class FizzBuzzTests
    {      
        [Theory]
        [InlineData(1,"1")]
        [InlineData(3,"Lucky")]
        [InlineData(5,"Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzKata(int number,string expected)
        {
            var result = new FizzBuzz(new List<IRules> { new Lucky(), new FizzBuzzChecker(), new Fizz(), new Buzz() }).Check(number);
            Assert.Equal(expected, result);
        }      

        [Fact]
        public void FizzBuzzLucky_()
        {
            var numbers = Enumerable.Range(1, 23).ToArray();
            var result = new FizzBuzz(new List<IRules> { new Lucky(), new FizzBuzzChecker(), new Fizz(), new Buzz() }).Check(numbers);
            Assert.Equal("1, 2, Lucky, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, Lucky, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, Lucky", result);
        }
    }
}