using System;

namespace OopBasics
{
    //Singelton design pattern is used to create only one 'INSTANCE'/'OBJECT' of the class
    class SingletonClass
    {
        
            //We need to create a local private variable of this call inside class to hold single object
            private static SingletonClass myobject;
            //'private' constructor, so no one can create object outside of this class
            private SingletonClass()
            {

            }

            //This function is public and static and it will return 'Instance' of 'DBManager' class
            public static SingletonClass GetInstance()
            {
                //check if this is first call from outside world
                if (myobject == null)
                    myobject = new SingletonClass();

                //return object
                return myobject;
            }

            //non-static function
            public void Show()
            {
                Console.WriteLine("SingletonClass.Show()");
            }
    }
}
