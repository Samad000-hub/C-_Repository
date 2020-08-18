using System;

namespace OopBasics
{
    // In C#, One class can not inherit methods etc from multiple classes.
    public class InheritanceClass1
    {
        public void Show1()
        {
            Console.Write("I am from Inheritance Parent Class 1");
        }
        public void Show2()
        {
            Console.Write("I am from Inheritance Parent Class 1");
        }
        public virtual void Show3()
        {
            Console.Write("I am from Inheritance Parent Class 1");
        }
    }
}
