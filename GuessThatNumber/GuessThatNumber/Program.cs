﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    public class Program
    {
        //this is the number the user needs to guess.  Set its value in your code using a RNG.
        static int NumberToGuess = 0;
  
        static void Main(string[] args)
        {   //calls GuessThatNumber function
            GuessThatNumber();

            //keeps the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Has the user guess a random number between 1 and 100
        /// </summary>
        public static void GuessThatNumber()
        {   //counts the number of times it takes the user to guess
            int numberOfTries = 0;
            //Welcomes the user
            Console.WriteLine("Yarrrr! So ye think ya can guess me lucky number? Try it and see if ye walk the plank instead!");
            //creates an integer and sets it to 0
            int intInput = 0;
            //empty string to store user input
            string userInput = null;
            //boolean flag to end while loop that ends when the number has been guessed
            bool numberHasNotBeenGuessed = true;

            //generates random number
            Random rng = new Random();
            //sets the number to guess to be genereated between 1 and 100
            SetNumberToGuess(rng.Next(1, 101));

            //loops through code until the number has been guessed
            while (numberHasNotBeenGuessed)
            {
                //stores user input to the empty <userInput> string
                userInput = Console.ReadLine();
                //checks if the input is a valid input (number)
                if (ValidateInput(userInput.ToString()))
                {   
                    //if it is valid, convert it to an integer
                    intInput = Convert.ToInt32(userInput);

                    //checks if the number is lower than 1 or greater than 100
                    if (intInput <= 0 || intInput >= 101)
                    {
                        //prints an error message that prompts the user to guess again
                        Console.WriteLine("Sorry matey, the number is between 1 and 100. Try again!");
                        //adds to the number of tries counter
                        numberOfTries++;
                    }
                    else if (NumberGuessed(intInput))
                    {
                        //if the guess is between 1 and 100 and == the number to guess
                        //adds to the guess counter
                        numberOfTries++;
                        //ends the while loop
                        numberHasNotBeenGuessed = false;
                    }
                        //if the guesss is too low, call the <IsGuesToLow function with the user input
                        //converted to an integer
                    else if (IsGuessTooLow(intInput))
                    {
                        //print message telling the user that the number is too low and to guess again
                        Console.WriteLine("Yar har har, ye guess was too low! Try again!");
                        //adds to the guess counter
                        numberOfTries++;
                    }
                        //if the guess is higher than the number to guess
                    else if (IsGuessTooHigh(intInput))
                    {
                        //print message telling the user that the number is too high and to guess again
                        Console.WriteLine("Ye guess wasn't even close, lad! It was too high, but no quarter! Guess again");
                        //adds to the guess counter
                        numberOfTries++;
                    }
                }
                else
                {   //error message
                    Console.WriteLine("Sorry matey, that be not a number I recognize. Give another go at it or it's the plank for you!");
                }
            }
            //lets the user know how many times it took them to guess the number
            Console.WriteLine("It took ye {0} tries to guess me lucky number. Good enough, I suppose. Say, want to meet my talking parrot?", numberOfTries);
        }

        /// <summary>
        /// Checks if the user input is a valid input
        /// </summary>
        /// <param name="userInput">Input to check</param>
        /// <returns></returns>
        public static bool ValidateInput(string userInput)
        {
            //loops through the input
            for(int i = 0; i < userInput.Length; i++)
            {   //if a character of the input is a letter
                if (Char.IsLetter(userInput[i]))
                {
                    //doesn't pass and the input isn't a valid input
                    return false;
                }
               
            }
            //if it isn't a letter, returns true
            return true;
           
        }

        /// <summary>
        /// Checks if the number to guess is equal to the 
        /// user guess for TESTING purposes ONLY
        /// </summary>
        /// <param name="number"></param>
        public static void SetNumberToGuess(int number)
        {
            //makes the function return true because the
            //<NumberToGuess> equals the user input
            NumberToGuess = number;

        }

        /// <summary>
        /// Checks if the user input is equal to the number to guess
        /// </summary>
        /// <param name="userGuess">User's guess</param>
        /// <returns></returns>
        public static bool NumberGuessed(int userGuess)
        {
            //checks if the user input equals the number to guess
            if (userGuess == NumberToGuess)
            {   //if so, makes the bool true
                return true;
            }
            //if it doesn't, set the boolean to false
            return false;

        }

        /// <summary>
        /// Checks if the user guess is higher than the number to guess
        /// </summary>
        /// <param name="userGuess">User's guess</param>
        /// <returns></returns>
        public static bool IsGuessTooHigh(int userGuess)
        {
            //checks if the user's guess is higher than the number to guess
            if (userGuess > NumberToGuess)
            {
                //if it is, change the bool to true
                return true;
            }
            //if it is not, change the bool to false
            return false;
        }

        /// <summary>
        /// Checks if the user guess is lower than the number to guess
        /// </summary>
        /// <param name="userGuess">User's guess</param>
        /// <returns></returns>
        public static bool IsGuessTooLow(int userGuess)
        {
            //Checks if the user guess is lower than the number to guess
            if (userGuess < NumberToGuess)
            {
                //if it is, change the bool to true
                return true;
            }
            //if it is not, change the bool to false
            return false
;
        }


    }
}