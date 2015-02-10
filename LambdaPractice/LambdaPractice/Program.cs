using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            
            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();

            //print the kayakProducts to the console using a foreach loop.
            foreach(string item in kayakProducts)
            {
                Console.WriteLine(item);
            }

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            Console.WriteLine();
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach(string item in shoeProducts)
            {
                Console.WriteLine(item);
            }

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            Console.WriteLine();
            List<string> ballProducts = products.Where(x => x.ToLower().Contains("ball")).ToList();

            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach(string item in ballProducts)
            {
                Console.WriteLine(item);
            }

            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine();
            List<string> ballProductsAlphabetized = ballProducts.OrderBy(x => x).ToList();
            foreach(string item in ballProductsAlphabetized)
            {
                Console.WriteLine(item);
            }

            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine();
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());

            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine();
            Console.WriteLine(products.OrderBy(x=> x.Length).First());

            //print the product with the 3rd shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).  
            Console.WriteLine();
            List<string> thirdShortest = products.OrderBy(x => x.Length).Skip(2).Take(1).ToList();
            
            foreach(string item in thirdShortest)
            {
                Console.WriteLine(item);
            }

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()). 
            Console.WriteLine();
            List<string> secondLongestBallName = ballProducts.OrderByDescending(x => x.Length).Skip(1).Take(1).ToList();
            foreach(string item in secondLongestBallName)
            {
                Console.WriteLine(item);
            }

            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            Console.WriteLine();
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();
           
            //print out the reversedProducts to the console using a foreach loop.
            foreach (string item in reversedProducts)
            {
                Console.WriteLine(item);
            }

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            Console.WriteLine();
            foreach (string item in products.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(item);
            }

            //FILL IN THE FUNCTIONS BELOW TO MAKE THE TESTS PASS

            Console.ReadKey();
        }

        public static string LongestName(List<string> inputList)
        {
            //with the input list, return the item with the longest name
            string longestName = inputList.OrderBy(x => x.Length).Last().ToString();
            return longestName;
        }

        public static string ShortestName(List<string> inputList)
        {
            //with the input list, return the item with the shortest name
            string shortestName = inputList.OrderBy(x => x.Length).First().ToString();
            return shortestName;
        }

        public static string SecondLongestName(List<string> inputList)
        {
            //with the input list, return the item with the second longest name
            string secondLongest = inputList.OrderByDescending(x => x.Length).Skip(1).First();
            return secondLongest;
        }

        public static string ThirdShortestName(List<string> inputList)
        {
            //with the input list, return the item with the third shortest name
            string thirdShortest = inputList.OrderBy(x => x.Length).Skip(2).First();
            return thirdShortest;
        }

        public static List<string> BallProducts(List<string> inputList)
        {
            //with the input list, return a list with only the the products that contain the word ball
            List<string> ballProducts = inputList.Where(x => x.ToLower().Contains("ball")).ToList();
            return ballProducts;
        }
        public static List<string> EndInS(List<string> inputList)
        {
            //with the input list, return a list with only the the products that end with the letter s
            List<string> endsInS = inputList.Where(x => x.EndsWith("s")).ToList();
            return endsInS;
        }
    }
}