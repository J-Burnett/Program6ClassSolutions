using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsInClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            DoStudentExamples();
            //var students = new List<Student>();
            //List<string> names = students.Select(x => x.Name).ToList();
            //IEnumerable<Student> enrolledStudents = students.Where(x => x.CourseList.Count > 0);

            //ShowCourseConstructors();

            Console.ReadKey();
        }

        static void DoStudentExamples()
        {
            Student student1 = new Student("John McClary", StudentRank.Senior);
            student1.CourseList.Add(new Course("Professional Development", "B"));
            student1.CourseList.Add(new Course("Programming", "D"));
            student1.CourseList.Add(new Course("Hockey History 101", "A"));
            student1.CourseList.Add(new Course("Being named John","F"));

            Student student2 = new Student("Nicole Winno", StudentRank.Junior);
            student2.CourseList.Add(new Course("Professional Development", "B"));
            student2.CourseList.Add(new Course("Programming", "c"));
            student2.CourseList.Add(new Course("Hockey History 101", "A"));
            student2.CourseList.Add(new Course("Being named John", "A"));


            student1.PrintStudentInfo();
            student2.PrintStudentInfo();
        }

        static void ShowCourseConstructors()
        {
            Course course1 = new Course();
            Course course2 = new Course("Biology");
            Course course3 = new Course("Math 101", "A");

            course1.PrintCourseInfo();
            course2.PrintCourseInfo();
            course3.PrintCourseInfo();

            course2.LetterGrade = "B";
            course2.PrintCourseInfo();

        }

        //new function here

    }
    //new classes here

    public class Course
    {
        //Step 1. Define properties
        
        //creating properties
        //step 1: Create the hide-behind variable
        private string _name;
        //step 2: Create the property layer that sits ontop of that variable
        //It controls the interaction with the variable
        public string Name
        {
            //read only property
            get
            {
                //Getter: whenever the value is on the right side of an equation this code is run
                //eg. myString = myObject.Name;
                return _name.ToUpper();
            }
            //write only property
            set
            {
                //Setter: whenever the property is on the left side of an equation, this code is run
                ///eg. myObject.Name = "Nickelback";
                _name = value;
            }
        }

        private string _letterGrade;

        public string LetterGrade
        {
            get { return _letterGrade; }
            set { _letterGrade = value.ToUpper();} 
        }

        //for the Grade Points, we are going to do a READ-ONLY property
        public double GradePoints
        {
            get
            {
                switch (this.LetterGrade)
                {
                    case "A":
                        return 4.0;
                    case "B":
                        return 3.0;
                    case "C":
                        return 2.0;
                    case "D":
                        return 1.0;
                    default:
                        return 0.0;
                }
            }   
        }

        //Creating a new class: STEP 2: Define constructor(s)
        //parameter list constructor, think of it as our default constructor

        public Course()
        {
            this.Name = "undefined";
            this.LetterGrade = "I";
        }

        //Parameterfull constructor, more common, this is the constructor you'll usually use
        public Course(string name)
        {
            this.Name = name;
            this.LetterGrade = "I";
        }

        public Course(string name, string letterGrade)
        {
            this.Name = name;
            this.LetterGrade = letterGrade;
        }

        //Creating a new class: Step 3: Define its Methods (actions)
        public void PrintCourseInfo()
        {
            Console.WriteLine("{0,25} {1, 2} {2, 3}", this.Name, this.LetterGrade, this.GradePoints);
        }
    }
    //DEFINING AN ENUMERATION (ENUM)
    public enum StudentRank
    {
        //automatically assigns a numberical value to them, starting with 0
        //but you can set it to whatever number you would like and they will
        //continue to increment from that value onward
        //EG. set Freshman = 5, then Sophmore will = 6
        //DO NOT HAVE TO BE UNIQUE, BUT THE NAME HAS TO BE UNIQUE
        //plus you don't really want to do that
        Freshman,
        Sophmore,
        Junior,
        Senior
    }

    public class Student
    {
        //Step 1: define the properties
        private string _name;

        public string Name
        {
            get { return _name; } //eg. Console.WriteLine(myObj.name);
            set { _name = value; }//eg. myObj.Name = "Patrick Yee";
            
        }


        private List<Course> _courseList;
        public List<Course> CourseList
        {
            get { return _courseList; }
            set { _courseList = value; }
        }

        //read only function
        public double GPA
        {
            get 
            {
                //total grade points divided by number of classes
                return this.CourseList.Average(x => x.GradePoints);
            }
        }


        private StudentRank _studentRank;
        public StudentRank StudentRank
        {
            get { return _studentRank; }
            set { _studentRank = value; }
        }

        //shorthand property declaration
        //public StudentRank StudentRank { get; set; }

        //other properties might include: age, studentID, DOB, major, ClassRank, Drink Pref, Gender

        //STEP 2: CONSTRUCTORS!!!
        public Student(string name, StudentRank rank)
        {
            this.Name = name;
            this.CourseList = new List<Course>(); //make sure to initialize any lists
            this.StudentRank = rank;
        }

        //Step 3: Methods!
        public void PrintStudentInfo()
        {
            //prints the students name
            Console.WriteLine("Name: {0}", this.Name);
            //prints the student's course list
            foreach(Course course in this.CourseList)
            {
                course.PrintCourseInfo();   
            }

            //this.CourseList.ForEach(x => x.PrintCourseInfo());//same thing as the foreach, but with a lambda
            Console.WriteLine("GPA: {0}", this.GPA);

        }
    }

}
