using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops numbers 1 through 20 in FizzBuzz Function 
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }
            //line for readibility
            Console.WriteLine();
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            //keeps console open
            Console.ReadKey();
        }

        /// <summary>
        /// Checks if a number is divisible by 3 & 5, 3, or 5 and prints
        /// FizzBuzz, Buzz, or Fizz, respectively
        /// </summary>
        /// <param name="number">Number to check</param>
        static void FizzBuzz(int number)
        {
            //checks if number is evenly divisible by 3 & 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                //prints FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
            //checks if its divisible by just 3
            else if (number % 3 == 0)
            {
                //prints buzz
                Console.WriteLine("Buzz");
            }
            //checks if its divisible by just 5
            else if (number % 5 == 0)
            {
                //prints Fizz
                Console.WriteLine("Fizz");
            }
            //otherwise,
            else
            {
                //prints the number
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Checks how many times a certain letter is in a string,
        /// both uppercase and lower case versions, and keeps track
        /// of the total number of occurances
        /// </summary>
        /// <param name="letter">Letter to look for</param>
        /// <param name="inString">String to look for the letter in</param>
        static void LetterCounter(char letter, string inString)
        {
            //counters for uppercase, lowercase, and total number of occurances
            int capitalLetterCounter = 0;
            int lowerCaseLetterCounter = 0;
            int allLettersCounted = 0;


            //loops through each character in a string
            for (int i = 0; i < inString.Length; i++)
            {
                //checks if its the letter we're looking for as a lowercase
                if (letter == inString[i])
                {
                    //if so, add to the counter
                    lowerCaseLetterCounter++;
                }
                //checks if its the letter as an uppercase
                if (letter.ToString().ToUpper() == inString[i].ToString())
                {
                    //if so, adds to that counter
                    capitalLetterCounter++;
                }
            }
            //counts all occurances of both uppercase and lowercase occurances
            allLettersCounted = capitalLetterCounter + lowerCaseLetterCounter;

            //prints results to the console
            Console.WriteLine(@"Input: 
{0}

Number of lowercase: {1}
Number of UPPERCASE: {2}
Total Number of {3}'s found: {4}
", inString, lowerCaseLetterCounter, capitalLetterCounter, letter, allLettersCounted);
        }
    }
}
