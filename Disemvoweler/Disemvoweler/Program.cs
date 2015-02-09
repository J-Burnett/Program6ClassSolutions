using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {

            //calling the function Disemvowler
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could Bear Grylls grill if Bear Grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");


            // keep the console open
            Console.ReadKey();
        }
        public static string Disemvoweler(string input)
        {
            //creating empty strings to store letters and special characters
            string vowelsRemoved = string.Empty;
            string disemvoweled = string.Empty;
            string specialCharacters = string.Empty;

            //checking each letter in the input string
            foreach (char character in input.ToLower())
            {   //checks if the current character is a vowel
                if (character== 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {   //if so, add it to the vowelsRemoved string
                        vowelsRemoved += character;
                }
                    //if its not a vowel, checks if it is a special character 
                else if (character == ' ' || character == '!' || character == '.' || character == ',' || character == '?' || character == '\'')
                {   //if so, adds to the special characters string
                    specialCharacters += character;
                }
                    //otherwise,
                else
                    {   //adds the character to the consonants, <disemvoweled> string
                        disemvoweled += character;
                    }
                
            }

            // Write out the various string results
            Console.WriteLine("Original:\n{0}\n", input);
            Console.WriteLine("Disemvoweled:\n{0}\n", disemvoweled);
            Console.WriteLine("Vowels Removed:\n{0}\n", vowelsRemoved);
            Console.WriteLine("\n");
            // Return the Disemvoweled string as well for testing
            return disemvoweled;
        }
    }
}
