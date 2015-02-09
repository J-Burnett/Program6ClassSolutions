using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPractice
{
    class Program
    {
        public static List<string> iceCreamList = new List<string>() { "vanilla", "chocolate", "strawberry", "coffee", "cherry", "praline pecan", "rocky road", "butter pecan", "cookies and cream", "vanilla fudge ripple" };
        static void Main(string[] args)
        {
            string myString = "lambda";
            //For loop
            for(int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }

            //For each example
            foreach(char letter in myString)
            {
                Console.WriteLine(letter);
            }

            //Lambda expressions


            //Where()


            //Keeps console open
            Console.ReadKey();
        }
    }
}
