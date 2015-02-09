using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);
            ChangeAmount(6548.21m);

            Console.ReadKey();
        }

        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();

            decimal originalAmount = amount;
            

            //contines to loop until the amount reaches 0
            while (amount > 0m)
            {
                //checks if the amount is over 100
                if(amount >= 100.00m)
                {   //if so, subtract 100
                    amount -= 100.00m;
                    //add 1 to the Hundreds counter
                    amountAsChange.Franklins++;
                }
                    //if the amount is less than 100 but greater >= 50
                else if (amount >= 50.00m)
                {   //subtract 50 from the amount
                    amount -= 50.00m;
                    //add 1 to the Fifties counter
                    amountAsChange.Grants++;
                }
                    //if the amount is less than 50 but >= 20
                else if (amount >= 20.00m)
                {   //subtract 20 from the amount
                    amount -= 20.00m;
                    //add 1 to the Twenties counter
                    amountAsChange.Jacksons++;
                }
                    //if the amount is less than 20 but >=10
                else if(amount >= 10.00m)
                {   //subtract 10 from the amount
                    amount -= 10.00m;
                    //add 1 to the Tens counter
                    amountAsChange.Hamiltons++;
                }
                    //if the amount is  less than 10 but >= 5
                else if(amount >= 5.00m)
                {   //subtract 5 from the amount
                    amount -= 5.00m;
                    //add 1 to the Fives counter
                    amountAsChange.Lincolns++;

                }   //if the amount is less than 5 but >=1
                else if(amount >= 1.00m)
                {   //subtract 1 from amount
                    amount -= 1.00m;
                    //add 1 to Ones counter
                    amountAsChange.Washingtons++;

                }   //if the amount is less than 1 but >= 0.25
                else if (amount >= 0.25m)
                {   //subtract 0.25 from the amount
                    amount -= 0.25m;
                    //add 1 to the Quarters counter
                    amountAsChange.Quarters++;
                }   
                    //if the amount is less than 0.25 but >=0.10
                else if (amount >= 0.10m)
                {   //subtract 0.10 from the amount
                    amount -= 0.10m;
                    //add to the Dimes counter
                    amountAsChange.Dimes++;
                }   
                    //if the amount is less than 0.10 but >= 0.05
                else if (amount >= 0.05m)
                {   //subtract 0.05
                    amount -= 0.05m;
                    //add to the Nickles counter
                    amountAsChange.Nickles++;
                }
                    //otherwise,
                else
                {   //subtract 0.01
                    amount -= 0.01m;
                    //add to the Pennies counter
                    amountAsChange.Pennies++;
                }
            }

            
            //prints the amount to the console
            Console.WriteLine("Amount: {0:C}", originalAmount);

            //printing the results to the console
            Console.WriteLine("Franklins: {0}", amountAsChange.Franklins);
            Console.WriteLine("Grants: {0}", amountAsChange.Grants);
            Console.WriteLine("Jacksons: {0}", amountAsChange.Jacksons);
            Console.WriteLine("Hamiltons: {0}", amountAsChange.Hamiltons);
            Console.WriteLine("Lincolns: {0}", amountAsChange.Lincolns);
            Console.WriteLine("Washingtons: {0}", amountAsChange.Washingtons);
            Console.WriteLine();
            Console.WriteLine("Coins:");
            Console.WriteLine("Quarters: {0}", amountAsChange.Quarters);
            Console.WriteLine("Dimes: {0}", amountAsChange.Dimes);
            Console.WriteLine("Nickles: {0}", amountAsChange.Nickles);
            Console.WriteLine("Pennies: {0}", amountAsChange.Pennies);
            Console.WriteLine();

            

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is a property to hold the number of Hundreds to be returned as change
        /// </summary>
        public int Franklins { get; set; }

        /// <summary>
        /// This is a property to hold the number of Fifties to be returned as change
        /// </summary>
        public int Grants { get; set; }

        /// <summary>
        /// This is a property to hold the number of Twenties to be returned as change
        /// </summary>
        public int Jacksons { get; set; }

        /// <summary>
        /// This is a property to hold the number of Tens to be returned as change
        /// </summary>
        public int Hamiltons { get; set; }

        /// <summary>
        /// This is a property to hold the number of Fives to be returned as change
        /// </summary>
        public int Lincolns { get; set; }

        /// <summary>
        /// This is a property to hold the number of Ones to be returned as change
        /// </summary>
        public int Washingtons { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
