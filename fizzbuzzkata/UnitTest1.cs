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
        public string check(int number) {
            return "1";

        }
    }
}