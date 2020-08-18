using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClasswithMethods
    {
        public string title;
        public string nation;
        public int id;

        public ClasswithMethods(string aTitle,string aNation, int _id)
        {
            title = aTitle;
            nation = aNation;
            id = _id;
        }

        public int idInitialization
        {
            get {
                return id;
            }
            set {
                if (id<0)
                {
                    id = 0;
                }
            }
        }
    }
}
