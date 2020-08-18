using System;


// Output of any project will dll or assembly.
// Class is by default 'internal'
// Attributes or Variables are by default 'private'
namespace AdvancedOOP
{
    class InterfaceImplementation
    {
        static void Main(string[] args)
        {

            Parent p1 = new OneMoreChild();
            p1.ShowMe();
            Console.ReadKey();

        }
    }
    //Instance of 'interface' can't be created but 'Reference Variable' can be created
    // Interface is pure abstract.
    public interface Parent
    {
        //Methods must be public in an interface.
        public void ShowMe();
    }
    //An interface can inherit andother interface
    interface Child : Parent
    {
        // You have create one more interface with 'child name'
        // If child interface inherits parent interface then it is your wish
        // you can implement parent methods or not.
        // If you make simple class instead of child interface then you should 
        // have to implement parent interface methods.

    }

    class OneMoreChild : Child
    {
        // When you will implement method of Interface class It should be public.
        public void ShowMe()
        {
            Console.WriteLine("Now It is implementations");
        }

        public void OpenConnection()
        {

        }
    }

    
}
