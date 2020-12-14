using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book   // We are building a class to provide some abstraction and some encapsulation !
    {            // Encapsulations is hiding Details, hiding complexity ! with no acccess to outer world
        // access modifiers -control the access to the members of teh class !
        // public - > the code ouside this class has access to this particualr member !
        // public acess modifier can add it o mehtods , to fields
        // private -can be only accessed int the same class !
        public Book(string name)   // Constructor !
        {
            grades = new List<double>();
            this.name = name;  // this is implicit variable into methods and constructors , //
           //  we use it when we want to refer to an Object on we currently oerate on!
           // this Object i want to refer to field name. with the value "name"
        }

        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;  // lets find teh max value into our grade book list! // lets take minimum value in double.
            var lowGrade = double.MaxValue;

            foreach (double number in grades)
            {

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
                //Console.WriteLine(result);
            }
            //result = result / grades.Count; //to find the average Grade of Education/ Total Sum Result / Count-elements in the List-number of grades
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The Biggest Number is :{highGrade}");
            Console.WriteLine($"The Lowest Number is {lowGrade}");

        }

        private List<double> grades;
        private string name;
    }
}
