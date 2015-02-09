using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of all of the students in class
            List<string> studentList = new List<string>() { "Andrew", "Michael", "Linda", "Eugene", "Andrii", "Nate", "Nicole", "Sergio", "Mike", "Jason","Patrick", "Brandon S", "Brandon E", "Maria", "Daniel", "Tim", "Laura", "Juli" };
            
            //calling the random group generator function
            
            PickGroup(studentList, 4);

            //keeping the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Randomn selects students and places them into groups
        /// </summary>
        /// <param name="studentList">The names of all of the students in the class</param>
        /// <param name="groupSize">How big you want the groups to be</param>
        static void PickGroup (List <string> studentList, int groupSize)
        {
            //list to place in students in random groups 
            List<string> currentGroupList = new List<string>();

            //counter for group numbers
            int groupNumber = 1;

            //looping through the list of students
            while (studentList.Count != 0)
            {
                //creates a random number
                Random randomNumberGenerator = new Random();
                
                //selects a random number from 0 to the size of the class
                int randomStudent = randomNumberGenerator.Next(0, studentList.Count);

                //assigns the random number generated to to the index of the student in the <studentList>
                string currentStudent = studentList[randomStudent];

                //adds student to the current group
                currentGroupList.Add(currentStudent);

                //removes the student from the original class list
                studentList.Remove(currentStudent);

                //checks to see if the current group is full or if the class list is empty
                if (currentGroupList.Count == groupSize || studentList.Count == 0)
                {
                    //if so, prints the group name and students to the console
                    Console.WriteLine("GROUP " + groupNumber);
                    Console.WriteLine(string.Join("\n", currentGroupList));
                    //blank line for readibility
                    Console.WriteLine();
                    
                    //clearing the list of students
                    currentGroupList.Clear();
                    
                    //increment group number
                    groupNumber++;
                }
            }

         
        }
    }



}
