using System;

namespace AdvancedOOP
{
    class Inheritance
    {
        public Inheritance()
        {
            Console.Write("Default");
        }

        public Inheritance(int id)
        {
            Console.Write("Parameterized");
        }
    }

    class Inheritance2:Inheritance
    {
        public Inheritance2()
        {
            Console.Write("Default2");
        }


        // If you donot write 'base(id)' then When you will create object with
        // parameterized constructor. It will call default constructor of
        // Parent Class.
        // Otherwise it will call parameterized constructor.
        public Inheritance2(int id):base(id)
        {
            Console.Write("Parameterized 2");
        }
    }
}
