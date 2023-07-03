using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_Inheritance
{
    class Mother : Father
    {
        public static int Minus(int a, int b)
        {
            return a - b;

        }

        public void ProtectedVar()
        {
            this.Abc = 10;
            //Father.Abc = 10;
            //Abc = 10;
            //Mother.Abc = 10;
        }


    }
}
