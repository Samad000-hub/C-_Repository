using System;
using System.Collections.Generic;
using System.Text;

namespace OopBasics
{
    class InheritanceMainClass
    {
        static void Main(string [] args) {

            // We can call functions of 'i1'. Means with i1, you can call
            // functions which are available in 'InheritanceClass1' class.
            InheritanceClass1 i1 = new InheritanceClass2();
            i1.Show1();
            i1.Show2();
            i1.Show3();


            // Child class can not point to Parent Class.
            // Invalid Statement
            /*InheritanceClass2 i2 = new InheritanceClass1();
            i2.Show1();
            i2.Show2();
            i2.Show3();*/
            Console.ReadKey();
        }
    }
}
