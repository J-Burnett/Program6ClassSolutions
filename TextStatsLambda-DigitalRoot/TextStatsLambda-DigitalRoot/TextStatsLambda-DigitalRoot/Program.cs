using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("On the other hand, there are fingers. Two days from now will be yesterday. Scotty doesn't know.");

            Console.ReadKey();
        }

        /// <summary>
        /// Takes a input and find its root
        /// </summary>
        /// <param name="rootThisNumber">The number to be rooted</param>
        /// <returns></returns>
        public static int DigitalRoot(string rootThisNumber)
        {
            int intNumber = 0;
            //loops through the numbers in input
            foreach(char number in rootThisNumber)
            {
                //adds them together
                intNumber += int.Parse(number.ToString());

            }

            int rootNumber = 0;
            //loops through the numbers
            foreach(char number in intNumber.ToString())
            {
                //adds each number together
                rootNumber += int.Parse(number.ToString());
            }
            return rootNumber;
        }

        public static void TextStats(string inputString)
        {
            Console.WriteLine("Number of Words: {0}", NumberOfWords(inputString));
            Console.WriteLine("Number of Vowels: {0}", NumberOfVowels(inputString));
            Console.WriteLine("Number of Consonants: {0}", NumberOfConsonants(inputString));
            Console.WriteLine("Number of Special Characters: {0}", NumberOfSpecialCharacters(inputString));
            Console.WriteLine("Shortest Word: {0}", ShortestWord(inputString));
            Console.WriteLine("Longest Word: {0}", LongestWord(inputString));
            

        }
        public static int NumberOfWords(string inputString)
        {
            List<string> wordCount = new List<string>(inputString.Split(' '));
            return wordCount.Count();
        }

        public static int NumberOfVowels(string inputString)
        {
            return inputString.Count(x => "aeiou".Contains(Char.ToLower(x)));       
            
        }

        public static int NumberOfConsonants(string inputString)
        {
            return inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(Char.ToLower(x)));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => ". ,?;'!@#$%^&*()".Contains((x)));
        }

        public static string LongestWord(string inputString)
        {
            List<string> longest = new List<string>(inputString.Split(' '));
            return longest.OrderByDescending(x => x.Length).First();
        }

        public static string ShortestWord(string inputString)
        {
            List<string> longest = new List<string>(inputString.Split(' '));
            return longest.OrderBy(x => x.Length).First();
        }


    }
}
