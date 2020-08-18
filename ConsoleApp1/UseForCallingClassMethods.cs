using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UseForCallingClassMethods
    {
        static void Main(string [] args)
        {
            ClasswithMethods firstObject = new ClasswithMethods("Smile","Pakistan",1);
            Console.WriteLine(firstObject.id);
            Console.WriteLine(firstObject.title);
            Console.WriteLine(firstObject.nation);

            Console.ReadKey();
        }
    }
}
