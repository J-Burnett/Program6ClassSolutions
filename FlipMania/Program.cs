using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the FlipCoins function
            FlipCoins(10000);
            //calls the FlipForHeads function
            FlipForHeads(10000);

            Console.ReadKey();
        }

        /// <summary>
        /// Flips a "coin" to determine if it lands on heads or tails
        /// </summary>
        /// <param name="numberOfFlips">the number of times to flip the "coin"</param>
        static void FlipCoins(int numberOfFlips)
        {
            //counters for heads and tails
            int numberOfHeads = 0;
            int numberOfTails = 0;

            //check for vaild input
            if (numberOfFlips > 0)
            {
             

                //generates a random number
                Random RandomNumberGenerator = new Random();

                //flips the "coin" and adds to the respective heads or tails counter
                for (int i = 0; i <= numberOfFlips; i++)
                {
                    int flip = RandomNumberGenerator.Next(2);
                    if (flip == 0)
                    {
                        numberOfHeads++;
                    }
                    else
                    {
                        numberOfTails++;
                    }
                }
            }

            //calling and printing the functions to the console 
            Console.WriteLine("We flipped a coin {0} times", numberOfFlips);
            Console.WriteLine("Number of Heads: {0}", numberOfHeads);
            Console.WriteLine("Number of Tails: {0}", numberOfTails);
        }

        /// <summary>
        /// Counts how many flips it takes to achieve a 
        /// certain amount of heads flipped
        /// </summary>
        /// <param name="numberOfHeads">Number of times the user wants 
        ///                             the coin to land on heads</param>
        static void FlipForHeads(int numberOfHeads)
        {
            //counters for how many times heads has been flipped and
            //the total amount of flips
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;

            //random number generator to select heads or tails
            Random RandomNumberGenerator = new Random();

            //flipping the coin
            while (numberOfHeadsFlipped != numberOfHeads)
            {
                //increments the total amount of flips
                int flip = RandomNumberGenerator.Next(2);

                //increments the heads counter each time heads is flipped
                if (flip == 0)
                {
                    numberOfHeadsFlipped++;
                }
                totalFlips++;
            }

            Console.WriteLine("We are flipping a coin until we find {0} heads", numberOfHeads);
            Console.WriteLine("It took {0} to find {1} heads", totalFlips, numberOfHeads);
        }
    }
}
