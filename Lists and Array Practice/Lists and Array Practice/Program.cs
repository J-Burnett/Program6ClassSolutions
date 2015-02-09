using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_and_Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //fixed length array
            string[] foodArray = new string[5];
            //adding to the foodArray
            foodArray[0] = "quinoa";
            foodArray[1] = "grapes";
            foodArray[2] = "kimchi";
            foodArray[3] = "watermelon";
            foodArray[4] = "granola";

            //multidimensional arrays
            int[,] twoDArray = new int[5,5];
            int[, ,] threeDArray = new int[5, 5, 5];

            //at coordinate 1,1 the value is 7
            twoDArray[1, 1] = 7;
            //would print the value, 7
            Console.WriteLine(twoDArray[1,1]);

            //makes an array to a list
            List<string> foodList = foodArray.ToList();
            foodList.Add("peaches");

            //LISTS
            List<string> teams = new List<string>();
            teams.Add("broncos");
            teams.Add("tigers");
            teams.Add("eagles");

            

            Console.WriteLine("Before Sort:");
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            Console.WriteLine();

            teams.Sort();
            Console.WriteLine("After Sort:");
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
                
            }
            Console.WriteLine();

            Console.WriteLine("After insert at index 0:");
            teams.Insert(0, "niners");
            Console.WriteLine(teams[0]);
            Console.WriteLine(teams[1]);
            Console.WriteLine();

            Console.WriteLine("Does the list contain the broncos?");
            //looks to see if the list contains a specific string
            //and returns a boolean value
            if (teams.Contains("broncos"))
            {
                Console.WriteLine("Yes, it has the broncos");
            }

            Console.WriteLine("Broncos is located at index {0}", teams.IndexOf("broncos"));
        //keep the console open
        Console.ReadKey();
        }
    }
}
