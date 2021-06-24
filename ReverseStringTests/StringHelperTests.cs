using ConsoleApp1;
using Xunit;

namespace ReverseStringTests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("hello", "Hello")]
        [InlineData("gabriel", "Gabriel")]
        public void ShouldReceiveAWordAndCapitalizeTheFirstLetter(string text, string expectedResult)
        {
            var result = text.AddUpperCaseToTheFirstLetter();

            Assert.True(result == expectedResult);
        }

        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("hello world", "dlrow olleh")]
        public void ShouldReceiveSentenceAndReverseIt(string text, string expectedResult)
        {
            var result = text.ReverseString();

            Assert.True(result == expectedResult);
        }

    }
}
