using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args) //we use class to define a object of the given class //new keyword to instantiate a class to create Object
        {

            var p = new Program(); // we create here instance named p-Object of the class Program
                                   // p.Main(args);  We cant access like this through an instance
                                   //static is reffered to the class, static is not reffered to an instance Object !
                                   // Main Method is static, console.WriteLine is also static method !

            Book book = new Book("Scott's Grade Book");  //this way we dont create an Object, so we cant do iteration on it !
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);   // book is an Object variable, variable that hold the object !
            book.ShowStatistics();
            
            // static is not coonected with the instance, 
           


            //var grades = new List<double> { 12.7, 10.3, 6.11, 4.1 };  // < -this is an angle bracket // Lsit has dynamic size-chaneagable
            //// list is dynamically-sizable collection
            //grades.Add(56.1);
            //// Console.WriteLine(grades[0]); 


           

        }
    }
}
