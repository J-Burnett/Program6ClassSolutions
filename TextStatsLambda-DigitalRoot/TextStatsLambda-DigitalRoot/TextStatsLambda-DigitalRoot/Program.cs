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
            Console.WriteLine(DigitalRoot("3133"));
            Console.ReadKey();
        }

        /// <summary>
        /// Takes a input and find its root
        /// </summary>
        /// <param name="rootThisNumber">The number to be rooted</param>
        /// <returns></returns>
        public static int DigitalRoot(string rootThisNumber)
        {
            int totalSum = 0;
           
            while(rootThisNumber.Length > 1)
            {
                totalSum = rootThisNumber.Sum(x => int.Parse(x.ToString()));
                rootThisNumber = totalSum.ToString();
            }
            return totalSum;

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
           return inputString.Replace(" ", " ").Split(' ').Length;
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
          
            return inputString.Split(' ').OrderByDescending(x => x.Length).First();
        }

        public static string ShortestWord(string inputString)
        {
            return inputString.Split(' ').OrderBy(x => x.Length).First();
        }


    }
}
