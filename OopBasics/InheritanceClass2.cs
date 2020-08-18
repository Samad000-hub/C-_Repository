using System;
using System.Collections.Generic;
using System.Text;

namespace OopBasics
{
    //protected will become as they are private in 'InheritanceClass1'
    class InheritanceClass2 :InheritanceClass1
    {

        // If you put 'new' keyword with child function. This will hide function of 
        // child class.
        public new void Show1()
        {
            Console.Write("I am from Inheritance child Class 2");
        }
        public void Show2()
        {
            Console.Write("I am from Inheritance child Class 2");
        }

        // This will override function 'show3' of Parent class If you put 'virtual'
        // keyword with Parent function and 'override' kwyword with child function.
        // Then Child function will call instead of Parent's function.
        public override void Show3()
        {
            Console.Write("I am from Inheritance child Class 2");
        }
    }
}
