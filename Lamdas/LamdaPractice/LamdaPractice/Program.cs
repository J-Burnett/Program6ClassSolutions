using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPractice
{
    class Program
    {
        public static List<string> iceCreamList = new List<string>() { "death by chocolate", "chocolate almond", "vanilla", "chocolate", "strawberry", "coffee", "cherry", "praline pecan", "rocky road", "butter pecan", "cookies and cream", "vanilla fudge ripple" };
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
            List <string> temp = iceCreamList.OrderBy(x => x.Length).ToList();//adds items to new list in length order
            foreach(string flavor in temp)
            {
                Console.WriteLine(flavor);
            }

            //shortest
            Console.WriteLine(iceCreamList.OrderBy(x=>x.Length).First());

            //longest
            Console.WriteLine(iceCreamList.OrderBy(x=>x.Length).Last());//prints longest/last item

            //Where()
            List<string> choco = iceCreamList.Where(x => x.Contains("chocolate")).ToList();
            foreach(string item in choco)
            {
                Console.WriteLine(item);
            }

            //First()


            //Last()


            //OrderBy()


            //Skip()


            //Keeps console open
            Console.ReadKey();
        }
    }
}
