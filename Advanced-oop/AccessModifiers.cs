using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_oop
{
    //Public class
    public class Class1
    {
    }

    //By default a type has 'internal' access modifier
    class Class2
    {

    }

    internal class Class3
    {

    }

    public class A
    {
        private int prvA;
        public int pubA;
        protected int protA;
        internal int intrA;
        protected internal int protIntrA;

        // Difference between internal and protected internal:
        // If you access protected internal and internal members through 
        // inheritance in child class in other project then 'Protected Internal' 
        // will available. But internal member will not bcz We can use internal
        // member out of assembly.
    }

    public class B : A
    {
        void Test()
        {
            this.intrA = 0; //internal is inheriteted as it is public within assembly
            this.protA = 0;//protected is inheriteted
            this.pubA = 0;//public is inheriteted
            this.protIntrA = 0; //protected internal is inherited
        }

        void Test2()
        {
            A obj = new A();

            obj.intrA = 0; //internal member is accessible by Object + .
            obj.pubA = 0; //public member is accessible by Object + .
            obj.protIntrA = 0; //protected internal member is accessible by Object + .
        }
    }
    //This class can't be inherited futher
    sealed class AA
    {
    }

    /* Invalid declaration here
    class BB : AA
    {
    }
     */
}
