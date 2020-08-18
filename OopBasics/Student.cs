using System;

// namespace is a logical unit for holding classes
namespace OopBasics
{
    class Student
    {
        //Class Attributes
        public int id;
        public int age;
        public string name;

        //Default
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }

        //Parameterized Constructor
        public Student(int _id, int _age, string _name)
        {
            id = _id;
            age = _age;
            name = _name;
        }

        // Function is showing id , name and age of Student class
        public void Show()
        {
            // Instead of concatenation, I can use below formatting to show
            // some harde coded string as well as outputs of variables
            System.Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", id, name, age);
        }
    }
}
