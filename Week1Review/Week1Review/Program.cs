using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpaceRemover("this is a test string"));

            // a built in space remover
            string noSpaces = " lots of    spaces   ".Replace(" ", string.Empty);
            Console.WriteLine(  noSpaces);


            specificLetterCounter("i", "\"I like big butts and I cannot lie\"");

            Console.WriteLine(numberRounder(11));
            Console.WriteLine(numberRounder(10));
            Console.WriteLine(numberRounder(53));
            Console.WriteLine(numberRounder(102));
            Console.WriteLine(numberRounder(94));
            Console.WriteLine(numberRounder(87));
            Console.WriteLine(numberRounder(76));
            Console.WriteLine(numberRounder(69));
            Console.WriteLine(numberRounder(5));

            Console.WriteLine(dustinsNumberRounder(8));

            Console.WriteLine(annoyingTextFilter("nickleback"));

            Console.ReadKey();
        }

        /// <summary>
        /// Takes in a string, and removes all of the spaces
        /// </summary>
        /// <param name="inputString">String to despacify</param>
        /// <returns></returns>
        static string SpaceRemover(string inputString)
        {
            //declare an empty return string
            string returnString = string.Empty;

            //loop over each letter
            for(int i = 0; i < inputString.Length; i++)
            {
                //get an individual letter
                string letter = inputString[i].ToString();
                if (letter != " ")
                {
                    //huzzah letter is not a space
                    returnString += letter;   
                }
            }
            //loop completes, return our return string
            return returnString;
        }

        /// <summary>
        /// Counts the number of instances of a specific letter in a string
        /// </summary>
        /// <param name="letterToCount">letter to count</param>
        /// <param name="stringToSearch">string to search</param>
        static void specificLetterCounter(string letterToCount, string stringToSearch)
        {
            //<stringToSearch> has X number of letterToCount in it
            //Sally is sunny has "s" in it 3 times

            //counter for number of times the letter has been found
            int timesLetterHasBeenFound = 0;

            //loop through each letter
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                //converting the int i to a string value
                string letter = stringToSearch[i].ToString();
                
                //checking if the letter we pulled matches the letter
                //we are counting and making sure they are both lowercase
                if(letter.ToLower() == letterToCount.ToLower())
                {
                    //if it is that letter, add 1 to the counter
                    timesLetterHasBeenFound++;
                }

            }
            //printing a statement to the console about how many times we found the letter we were looking for
            Console.WriteLine("There are " + timesLetterHasBeenFound + " " + letterToCount + "'s in the string " + stringToSearch);
        }

        //numberRounder, rounds an integer to the nearest 5
        /// <summary>
        /// Rounding a number to the nearest number divisible by 5
        /// </summary>
        /// <param name="numberToRound">Number that you want to round</param>
        /// <returns>The nearest number divisible by 5 to the input number</returns>
        static int numberRounder(int numberToRound)
        {
            
            //my way to do it
            if (numberToRound % 5 == 0)
            {
                return numberToRound;
            }
           
            else if (numberToRound % 5 == 1)
            {
                return numberToRound - 1;
            }
            
            else if (numberToRound % 5 == 2)
            {
                return numberToRound - 2;
            }
            else if (numberToRound % 5 == 3)
            {
                return numberToRound + 2;
            }
            else if (numberToRound % 5 == 4)
            {
                return numberToRound + 1;
            }
           

            return 0;
        }

        static int dustinsNumberRounder(int numberToRound)
        {
            int remainder = numberToRound % 5;
            if(remainder > 2)
            {
                return numberToRound - remainder + 5;
            }
            else
            {
                return numberToRound - remainder;
            }
        }

        /// <summary>
        /// Take in a string, it will return a string with letters alternating between upper and lower case
        /// </summary>
        /// <param name="notAnnoyingString">string to make annoying</param>
        /// <returns>hard to read string</returns>
        static string annoyingTextFilter(string notAnnoyingString)
        {
            string returnString = string.Empty;

            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                string alternatingLetter = notAnnoyingString[i].ToString();

                if (notAnnoyingString[i] % 2 == 0)
                {
                    return returnString += alternatingLetter.ToUpper();
                }
                else
                {
                    return returnString += alternatingLetter.ToLower();
                }
            }
            return returnString;
        }
        
        
    }
 }

