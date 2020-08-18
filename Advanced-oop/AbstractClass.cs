/*using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedOOP
{
    class AbstractClass
    {
        static void Main(string [] args)
        {

            Szuki s1 = new Szuki();
            s1.Drive();
            // CarShow() will call from Szuki Class
            // If you create instance of Car Class then it will call of "Car" Class
            s1.CarShow();
            Console.ReadKey();

        }
    }

    //Instance of 'abstract' class can't be created but 'Reference Variable' can be created
    //Abstract class may have 0 or more 'abstract' methods.
    //abstract method can't be private
    //abstract class can also contain virtual methods.
    // Abstract Methods must over-rideable
    // Abstract class can not have constructor.
    abstract class Car
    {
        public abstract void Drive();

        public void CarShow()
        {
            Console.WriteLine("This is Car Class Mathod");
        }
    }

    class Szuki:Car
    {
        //If you will not give implementation of Drive method in child class
        // then error will occur.
        // OR  If you do not want to give implementation in child class
        // then your class should be abstract.
        public override void Drive()
        {
            Console.WriteLine("Now I am over-riding abstract method of Car Class");
        }

        public void CarShow()
        {
            Console.WriteLine("This is Szuki Class Mathod");
        }
    }
}
*/