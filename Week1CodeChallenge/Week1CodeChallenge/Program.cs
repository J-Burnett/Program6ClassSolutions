using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints the name of the call function
            Console.WriteLine("FizzBuzz: \n");

            //looping through the numbers 0 - 20
            for (int i = 0; i < 21; i++ )
            {
                //running the current number in 
                //the loop through the FizzBuzz function
                Console.WriteLine(FizzBuzz(i));
            }
            //space between two loops in the console 
            Console.WriteLine();

            //looping through the numbers 92-79
            for (int i = 92; i > 78; i-- )
            {
                //running the current number in 
                //the loop through the FizzBuzz function
                Console.WriteLine(FizzBuzz(i));
            }
            //prints name of the function and adds a blank space between functions
            Console.WriteLine("\nYodaizer: ");

            //calling the Yodaizer function
            Console.WriteLine(Yodaizer("I like code"));

            
            Console.WriteLine("\nTextStats: ");

            //calling the TextStats function
            TextStats("Nickelback is the best band ever. I love their lead singer with his long flowing locks. I hope they make music forever.");

            //prints name of the function and adds a blank space between functions
            Console.WriteLine("\nIsPrime: ");

            //loops through every other number from 1 to 25
            for (int i = 1; i < 26; i+=2 )
            {
                //runs <i> through the IsPrime call funcation
                if(IsPrime(i) == true)
                {
                    //if it returns true, prints to the console that the number is prime
                    Console.WriteLine("{0} is a prime number", i);
                }
                //otherwise,
                else
                {   
                    //prints <i> to the console
                    Console.WriteLine(i);
                }
            }

            //prints name of the function and adds a blank space between functions
            Console.WriteLine("\nDashInsert: ");

            //calling and printing the DashInsert function
            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));


                //keeping the console open
                Console.ReadKey();
        }

        /// <summary>
        /// Testing to see if a number is divisible by 
        /// 5, 3, both, or neither and printing either "Fizz", 
        /// "Buzz", "FizzBuzz", or the number, respectively
        /// </summary>
        /// <param name="number">The numbeer to check</param>
        /// <returns>"Fizz", "Buzz", "FizzBuzz", the input number</returns>
        public static string FizzBuzz(int number)
        {
           //checks to see if the number is negative
           if(number < 0 )
           {
               //if so, returns ""
               return "";
           }
           //checks if the number is evenly divisible by 3 & 5
           else if(number % 3 == 0 && number % 5 == 0)
           {
               //if true, returns "FizzBuzz", if not
               return "FizzBuzz";
           }
           //checks if the number is evenly divisible by 5
           else if (number % 5 == 0)
           {
               //if true, prints "Fizz", if not
               return "Fizz";
           }
           //checks if the number is evenly divisible by 3
           else if (number % 3 == 0)
           {
               //if true, prints "Buzz"
               return "Buzz";
           }
            //if none of the prior ones are true
           else
           {
               //returns the number after converting to a string
               return number.ToString();
           }
        }
        /// <summary>
        /// Takes a string and returns it in reverse order
        /// </summary>
        /// <param name="text">The string to reverse</param>
        /// <returns>The string in reverse order</returns>
        public static string Yodaizer(string text)
        {
            //creating an empty string
            string newString = string.Empty;
            //splitting the input text at the spaces, adding the each word
            //to a new list, <wordList>
            List<string> wordList = new List<string>(text.Split(' '));

            //reversing the order of the wordList
            wordList.Reverse();

            //loops through the wordList
            for (int i = 0; i < wordList.Count(); i ++)
            {
                //adds the the current word from the wordList at index i to the empty string
                newString = newString + wordList[i] + " " ; 

                //checks if the list is only three words long
                if(wordList.Count == 3)
                {
                    //if so, bring the last word to the front of the string and reorder the list
                    newString = wordList[0] + ", " + wordList[2] + " " + wordList[1];
                }
            }
            //return the new string
            return newString.TrimEnd();

        }

        /// <summary>
        /// Finding a variety of statistics of a string
        /// </summary>
        /// <param name="input">The string to get statistics from</param>
        static void TextStats(string input)
        {
            //counters for each statistic we are looking for
            int numberofCharacters = 0;
            int numberofWords = 0;
            int numberofVowels = 0;
            int numberofConsonants = 0;
            int numberofSpecialCharacters = 0;

            string longestWord = string.Empty;
            string secondLongestWord = string.Empty;
            string shortestWord = string.Empty;

            //used to see if there is a space in the input string
            bool spaceBetweenWords = false;

            //breaks up the input string and puts the new strings into a string list
            List<string> wordList = new List<string>();
            wordList = input.Split(' ').ToList();

            //loops through each character in the input string
            foreach (char character in input)
            {
                //checks to see if the character is a white space
                if (char.IsWhiteSpace(character))
                {
                    //if it is, changes the <spaceBetweenWords> bool to true
                    spaceBetweenWords = true;
                }
                else
                {
                    //otherwise, since its not a white space,
                    //it adds to the character counter
                    numberofCharacters++;
                }
                
            }
            //prints how many characters are in the input string
            Console.WriteLine("Number of Characters: {0}", numberofCharacters);

            //counts number of words in the string
            numberofWords = wordList.Count();
            //prints how many words are in the input string
            Console.WriteLine("Number of Words: {0}", numberofWords);

            //loops through each character in the input string
            foreach(char character in input)
            {
                //checks if the character is equal to a vowel
                if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    //if it does, adds to the vowel counter
                    numberofVowels++;
                }
                //if its not a vowel, checks to see if it is a special character
                else if(character == '.' || character == ' ' || character == '?' || character == ',')
                {
                    //if it is, adds to the special characters counter
                    numberofSpecialCharacters++;
                }
                //otherwise,
                else
                {
                    //it will add to the number of consonant counter
                    numberofConsonants++;
                }
            }
            //prints the results to the console
            Console.WriteLine("Number of Vowels: {0}", numberofVowels);
            Console.WriteLine("Number of Consonants: {0}", numberofConsonants);
            Console.WriteLine("Number of Special Characters: {0}", numberofSpecialCharacters);
            
            //looping through the word list
            for(int i = 0; i < wordList.Count; i++) 
            {
                //checking if the word at index <i> is greater
                //than the longest word found so far
                if(wordList[i].Length > longestWord.Length)
                {
                    //if so, set the word at index i equal to
                    //the longestWord string
                    longestWord = wordList[i]; 
                }  
            }
            //removes the longest word from the array
            wordList.Remove(longestWord);
            //looping through the word list
            for (int i = 0; i < wordList.Count; i++)
            {
                //checking if the word at index <i> is greater
                //than the longest word found so far
                if (wordList[i].Length > secondLongestWord.Length)
                {
                    //if so, set the word equal to the 
                    //<secondLongestWord string
                    secondLongestWord = wordList[i];
                    //checks if there is a period at the end of the string
                    if(secondLongestWord[secondLongestWord.Length - 1].ToString() == ".")
                    {
                        //if so, it deletes the period
                        secondLongestWord = secondLongestWord.Remove(secondLongestWord.Length - 1);
                    }
                }
            }
            //flag for ending the loop
            bool isFound = false;
            //counters for the word in
            //the list and its length
            int wordIndex = 0;
            int wordLength = 1;

            //checks the length of the words in the list
            while (!isFound)
            {
                //checks if the word is equal to the shortest
                //word length
                if (wordList[wordIndex].Length == wordLength)
                {
                    //if so, you've found the shortest word
                    isFound = true;
                    shortestWord = wordList[wordIndex];
                }
                //if not, add to the word index counter and
                //check the next word in the list
                wordIndex++;

                //if the you've finished looping through the 
                //list and there aren't any words with a length
                //equal to the inital word length,
                if (wordIndex ==( wordList.Count - 1) )
                {
                    //add 1 to the word length and reset
                    //the word index to 0 and start looping
                    //again
                    wordLength++;
                    wordIndex = 0;
                }
            }
            //print the results to the console
            Console.WriteLine("Longest Word: {0}", longestWord);
            Console.WriteLine("Second Longest Word: {0}", secondLongestWord);
            Console.WriteLine("Shortest Word: {0}", shortestWord); 
        }

        /// <summary>
        /// Test a number to see if it is a prime number
        /// </summary>
        /// <param name="number">Number to test</param>
        /// <returns>Whether the number is prime or not</returns>
        public static bool IsPrime(int number)
        {
            //checks if the number is equal to 1, 2, or 3
            if ( number == 1 || number == 2 || number == 3)
            {
                //if so, number is a prime
                return true;
            }
            //loops through all numbers less than the input number
            for (int i = 3; i < number; i ++)
            {
                //if the input number is even or can be evenly
                //divisible by any number less than itself,
                if(number % 2 == 0 || number % i == 0)
                {
                    //the number is not a prime number
                    return false;
                }
            }
            //in all other cases, the number is a i
            return true;
        }

        /// <summary>
        /// Insersts a dash (-) inbetween consecutive odd numbers in a number
        /// </summary>
        /// <param name="number">Number to insert dashes into</param>
        /// <returns>Number with dashes</returns>
        public static string DashInsert(int number)  
        {
            //converts input to a string
            string aNumberString = number.ToString();
            //empty string to store each char in number string
            string finalNumberString = string.Empty;
            //check if a number is odd or even
            for(int i = 0; i < (aNumberString.Length)-1; i++)
            {
                //numbers to check
                int NumberToCheck = int.Parse(aNumberString[i].ToString());
                int SecondNumberToCheck = int.Parse(aNumberString[i+1].ToString());
                //checks if the first number is odd
                if (NumberToCheck % 2 != 0)
                {
                    //if so, adds it to the empty string,
                    finalNumberString = finalNumberString + NumberToCheck;
                    //add checks if the next number is odd
                    if (SecondNumberToCheck % 2 != 0)
                    {
                        //if so, adds that to the empty string and inserts 
                        //a dash inbetween the two odd numbers
                        finalNumberString = finalNumberString + "-";
                    }
                }
                else
                {
                    //if the number is even, adds the number to the empty string
                    finalNumberString = finalNumberString + NumberToCheck.ToString();   
                }
            }
            //checks the last number and adds it to the end of the string
            int LastNumber = int.Parse(aNumberString[aNumberString.Length - 1].ToString());
            finalNumberString = finalNumberString + LastNumber.ToString();
            //returns the final string with dashes inserted
            return finalNumberString;
       } 
    }
}
