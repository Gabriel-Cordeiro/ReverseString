using ConsoleApp1;
using Xunit;

namespace ReverseStringTests
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData("Hello", "Olleh")]
        [InlineData("Hello World", "Olleh Dlrow")]
        [InlineData("", "")]

        public void ShouldReceiveSentenceAndReverseAllWordsCapitalizingFirstLetterForEachWord(string text, string expectedResult)
        {
            var result = Program.ProcessReverseString(text);

            Assert.True(result == expectedResult);
        }
    }
}
