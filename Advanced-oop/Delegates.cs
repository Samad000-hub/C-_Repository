using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_oop
{
    // Delegate is created in namespace.
    // Delegates use to point functions.
    public delegate int MyDelegate(int a, int b);
    class DelegateFunctions
    {
        // In delegates, Functions that we define=> Return type and parameters matter.
        static public int Sum(int a, int b)
        {
            Console.WriteLine("Sum is called");
            int c = a + b;
            return c * 2;
        }

        static int Mul(int x, int y)
        {
            Console.WriteLine("Mul is called");
            return x * y;
        }

        static void Main(string[] args)
        {
            MyDelegate f = Sum;
            f = f + Mul;

            var r = f(5, 10);
            Console.WriteLine("Result:{0}", r);

            Console.WriteLine("-------------------");
            f = f - Sum;

            r = f(5, 10);
            Console.WriteLine("Result:{0}", r);
            Console.WriteLine("-------------------");

            f = f - Mul;

            //r = f(5, 10);
            //Console.WriteLine("Result:{0}", r);
            Console.WriteLine("-------------------");
        }
    }

    /*
     Buitl-in Delegates:
    1: Action delegate => Which takes no parameters and its return type is void
    
    2: Action<T1,...,T16> => Takes parameters 1 to 16 and it does not return any value

    3: Func<TResult> => takes no parameters and its return type will TResult
     
    4: Func<T1,...,T16,TResult> => Takes parameters 1 to 16 and its return type will TResult

    5: Predicate<parameters> => takes parameters and Its return type is always boolean.
    Anonymous methods are the methods without a name, just the body.

    Delegates mostly use to hold anonymous functions.

    Anonymous functions have not name, only body.
     */
}

