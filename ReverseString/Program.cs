using System;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var finalWord = string.Empty;

            Console.WriteLine("Type a sentence to be reversed");
            var writtenSentence = Console.ReadLine();

            if (string.IsNullOrEmpty(writtenSentence))
                Console.WriteLine("Too bad, You didn't write any word");
            else
            {
                Console.WriteLine($"Your sentence reversed {ProcessReverseString(writtenSentence)}");
                Console.ReadKey();
            }
        }

        public static string ProcessReverseString(string writtenSentence)
        {
            var result = string.Empty;

            if (writtenSentence.Contains(" "))
            {
                var sentenceArray = writtenSentence.Split(' ').ToList();

                sentenceArray.ForEach(sentence =>
                {
                    string wordChar = sentence.ReverseString();
                    var reverseWord = wordChar.AddUpperCaseToTheFirstLetter();

                    result += $"{reverseWord} ";
                });
            }
            else
                result = writtenSentence.ReverseString().AddUpperCaseToTheFirstLetter();

            return result.TrimEnd();
        }

    }
}
