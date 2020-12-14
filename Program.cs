using System;
using System.Collections.Generic;

namespace CommonTutorilas
{
    class Program
    {
        static void Main(string[] args)
        {


            var grades = new List<double> { 12.7, 10.3, 6.11, 4.1 };  // < -this is an angle bracket // Lsit has dynamic size-chaneagable
            // list is dynamically-sizable collection
            grades.Add(56.1);
            // Console.WriteLine(grades[0]); 


            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
                //Console.WriteLine(result);
            }
            //result = result / grades.Count; //to find the average Grade of Education/ Total Sum Result / Count-elements in the List-number of grades
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");



            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
            // Console.WriteLine(args.Length);  // the array [] with a name : args doesn have filled elements
        }
    }
}
