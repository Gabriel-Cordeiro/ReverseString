using System;
using System.Linq;

namespace ConsoleApp1
{
    public static class StringHelper
    {
        public static string AddUpperCaseToTheFirstLetter(this string text)
        {
            if (!string.IsNullOrEmpty(text))
                return (char.ToUpper(text[0]) + text.Substring(1));
            else return text;
        }

        public static string ReverseString(this string sentenceArray) 
            => new string(sentenceArray.ToCharArray().Reverse().ToArray()).ToLower();
    }
}
