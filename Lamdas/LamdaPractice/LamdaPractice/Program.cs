using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPractice
{
    class Program
    {
        public static List<string> iceCreamList = new List<string>() { "vanilla", "death by chocolate", "death by chocolate", "chocolate almond", "vanilla", "chocolate", "strawberry", "coffee", "cherry", "praline pecan", "rocky road", "butter pecan", "cookies and cream", "vanilla fudge ripple" };
        static void Main(string[] args)
        {
            string myString = "lambda";
            //For loop
            for(int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }

            //For each example
            Console.WriteLine();
            foreach(char letter in myString)
            {
                Console.WriteLine(letter);
            }

            //Lambda expressions
            Console.WriteLine();
            List <string> temp = iceCreamList.OrderBy(x => x.Length).ToList();//adds items to new list in length order
            foreach(string flavor in temp)
            {
                Console.WriteLine(flavor);
            }

            //shortest
            Console.WriteLine();
            Console.WriteLine(iceCreamList.OrderBy(x=>x.Length).First());

            //longest
            Console.WriteLine();
            Console.WriteLine(iceCreamList.OrderBy(x=>x.Length).Last());//prints longest/last item

            //Where()
            Console.WriteLine(  );
            List<string> choco = iceCreamList.Where(x => x.Contains("chocolate")).ToList();
            foreach(string item in choco)
            {
                Console.WriteLine(item);
            }
            

            //OrderBy()
            Console.WriteLine();
            List <string> ordered = iceCreamList.OrderByDescending(x => x.Length).ToList();//ordered longest - shortest
            foreach(string item in ordered)
            {
                Console.WriteLine(item);
            }
           
            //Skip()
            Console.WriteLine();
            List<string> skipped = iceCreamList.OrderBy(x => x.Length).Skip(5).ToList();//ordered by length and skipped first 5
            foreach(string item in skipped)
            {
                Console.WriteLine(item);
            }

            //Take()
            Console.WriteLine("\ntake");
            List<string> temp1 = iceCreamList.Take(2).Where(y => y.ToLower().Contains("chocolate")).ToList();
            
            foreach(string item in temp1)
            {
                Console.WriteLine(item);
            }
            //Count()
            Console.WriteLine();
            int vanillaCount = iceCreamList.Count(x => x.ToLower().Contains("vanilla"));
            Console.WriteLine(vanillaCount);

            //Any()
            //true or false 
            Console.WriteLine();
            bool flavorName = iceCreamList.Where(x => x.Length > 10).Any();
            Console.WriteLine(flavorName);

            //Distinct
            Console.WriteLine("before distinct");
            Console.WriteLine(iceCreamList.Count());

            Console.WriteLine("after distinct");
            Console.WriteLine(iceCreamList.Distinct().Count());

            //Keeps console open
            Console.ReadKey();
        }
    }
}
