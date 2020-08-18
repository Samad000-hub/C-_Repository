/*// This Program.cs file has "Main" method in which i am creating objects,
// using other classes etc.

using System;

namespace OopBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            // std is 'Reference Variable/Pointer' of type 'Employee', not an object
            // Student std;

            //On left side, it is creating 'Reference variable/pointer' of type 'Employee'
            //On right side, it is creating 'Object' of type 'Employee' using 'new' operator
            //and empObj is holding address/reference of that object
            Student std = new Student(1,20,"Samad");

            //System is a namespace here
            //Consol is a class in System namespace
            //WriteLine is a 'static' method in 'Console' class
            //New get values from the object and print on the screen
            Console.WriteLine(std.id);
            Console.WriteLine(std.age);
            Console.WriteLine(std.name);

            // Use to pause output screen so that i can see my output.
            // We can also use System.Console.ReadLine();
            System.Console.ReadKey();
        }
    }
}
*/