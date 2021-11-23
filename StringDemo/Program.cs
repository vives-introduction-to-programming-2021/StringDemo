using System;

namespace StringDemo
{
    class Program
    {
        static void TryToChangeVariable(int value)
        {
            // We can change the variable value
            // but we can not change the original variable
            // that was passed when the method was called
            value = 666;
        }

        static void Main(string[] args)
        {
            // Declare string "Hello World!"
            string hello = "Hello World!";

            // Strings can be printed to the terminal
            Console.WriteLine(hello);

            // Strings have properties (such as Length)
            // and methods (such as ToLower())
            Console.WriteLine(hello.Length);    // Property
            Console.WriteLine(hello.ToLower()); // Method
            
            // Using the new keyword we can also create string object
            String world = new string("Hello World!");
                // string is alias of String

            Console.WriteLine(world);
            Console.WriteLine(world.Length);    // Property
            Console.WriteLine(world.ToLower()); // Method

            // Value types are copied !
            int number = 133;
            int someOtherValue = number;
                // the value of number is copied into someOtherValue

            // Here the value of number is copied into the argument
            // value of the method.
            // This means that the method will not be able to change
            // the original variable (number in this case)
            TryToChangeVariable(number);

            // Create object
            Coordinate here = new Coordinate();

            // Object properties
            here.X = 33;
            here.Y = 44;

            // The object is not copied !
            // The reference to the object is copied
            // In other words, we have two variables now that
            // reference the same single object
            Coordinate there = here;
            Console.WriteLine("X: " + there.X);
            Console.WriteLine("Y: " + there.Y);

            // Change to the object via either reference will
            // be reflect via all references
            there.X = 105;
            there.Y = 99;
            Console.WriteLine("-------------");
            Console.WriteLine("X: " + here.X);
            Console.WriteLine("Y: " + here.Y);
            Console.WriteLine("X: " + there.X);
            Console.WriteLine("Y: " + there.Y);
        }
    }
}
