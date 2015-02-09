﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {

        //call a global function outside of a function, but inside of a class
        static Random randomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FlipACoin());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FlipForHeads());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// flips a "coin"
        /// </summary>
        /// <returns>a string of either heads or tails</returns>
        static string FlipACoin()
        {
            int theFlip = randomNumberGenerator.Next(0, 2);
            if (theFlip == 0)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }


        /// <summary>
        /// flips a coin until a heads has been flipped
        /// </summary>
        /// <returns>the number of tries it took to flip a heads</returns>
        static int FlipForHeads()
        {
            //when to tell us to exit the loop
            bool headsHasNotBeenFlipped = true;
            //counter for how many times the coin was flipped
            int howManyFlips = 0;

            //flips the coin
            while (headsHasNotBeenFlipped)
            {
                //the flip
                string theFlip = FlipACoin();
                howManyFlips++;

                if (theFlip == "Heads")
                {
                    //if its a head, kill the loop
                    headsHasNotBeenFlipped = false;
                }
            }
            //returns the # of times the coin was flipped
            return howManyFlips;
        }

    }
}