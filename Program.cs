using System;

namespace CommonTutorilas
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = 34.1;  // keywaord var is kind of implicit typing, it decides alone the type of the literal;
            double y = 10.3;
           

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
