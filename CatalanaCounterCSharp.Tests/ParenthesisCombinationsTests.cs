
namespace CatalanaCounterCSharp.Tests
{
    public class ParenthesisCombinationsTests
    {
        [Theory]
        [InlineData(0, 1)] // C(0) = 1
        [InlineData(2, 1)] // C(1) = 1 ("()")
        [InlineData(4, 2)] // C(2) = 2 ("(())", "()()")
        public void ValidInputs_ReturnsResult(int input, int expected)
        {
            var result = ParenthesisCombinations.CountWellFormedParenthesis(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3)]
        [InlineData(100)]
        public void InvalidInputs_ThrowsException(int input)
        {
            Assert.Throws<ArgumentException>(() => 
                ParenthesisCombinations.CountWellFormedParenthesis(input));
        }
    }
}