using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //function call for the vowel counter
            string testString = "\"This is a test string\"";
            Console.WriteLine("We found {0} vowels in {1}", VowelCounter3000(testString), testString);

            //counting the number of vowels in a string
            Console.WriteLine(testString.Count(x => "aeiou".Contains(x.ToString().ToLower())));

            //function call for the average word length finder
            Console.WriteLine("The average length of a word in {0} is {1}", testString, AverageWordLengthFinder8000(testString));

            //another way to calculate the average using lambdas
            // => is a token which just separates different parts
            Console.WriteLine(testString.Split(' ').Average(x => x.Length));

            

            //calling the Old Timey Printer
            oldTimeyTextPrinter(testString, 10);
            oldTimeyTextPrinter(testString, 80);
            oldTimeyTextPrinter(testString, 5);


            Console.ReadKey();
        }

        //new functions are declared outside of other functions, but inside of a class
        /// <summary>
        /// Count the number of vowels in a string
        /// </summary>
        /// <param name="inputText">the string to analyze</param>
        /// <returns>The number of vowels found</returns>
        static int VowelCounter3000(string inputText)
        {
            //this is our counter for vowels
            int numberOfVowelsFound = 0;

            //we need to loop through all indexes to compare each letter


            //"hello" is 5 chars long, but the last index is 4
            for (int i = 0; i < inputText.Length; i++)
            {
                //pulling out an individual letter and converting it to the lowercase
                char letter = char.ToLower(inputText[i]);
                //is it a vowel?
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    //yes, it is a vowel! count it!
                    numberOfVowelsFound++;
                }
            }
            //loop complete. gone through every letter of the string. counted all of the vowels. return the number of vowels found.
            return numberOfVowelsFound;
        }

        /// <summary>
        /// Finds the average length of a word in a string
        /// </summary>
        /// <param name="inputString">string to analyze</param>
        /// <returns>average amount of characters in a word</returns>
        static double AverageWordLengthFinder8000(string inputString)
        {
            //counts the total number of characters
            //count the total number of words
            double totalNumberOfCharacters = 0;
            double totalNumberOfWords = 0;

            //we need to split a string into words
            //"hello how are you" >>> "hello|how|are|you"
            string[] wordArray = inputString.Split(' ');

            //loop over each word in our wordArray
            for (int i = 0; i < wordArray.Length; i++)
            {
                //get the current word
                string currentWord = wordArray[i];
                //lets process the word
                totalNumberOfWords++;
                totalNumberOfCharacters += currentWord.Length;
            }

            //return our results
            //average = total/number of items

            return totalNumberOfCharacters / totalNumberOfWords;

        }

        /// <summary>
        /// prints text to the screen like an old timey text printer
        /// </summary>
        /// <param name="inputText">text to print</param>
        /// <param name="pauseDuration">break between the characters in milliseconds</param>
        static void oldTimeyTextPrinter(string inputText, int pauseDuration)
        {
            //loop over each character
            for (int i = 0; i < inputText.Length; i++)
            {
                //get a letter
                char letter = inputText[i];
                //print the letter to the screen
                Console.Write(letter);
                //create a pause
                System.Threading.Thread.Sleep(pauseDuration);
            }

            //after the text is complete, write a line break
            Console.WriteLine();
        }
    }
}