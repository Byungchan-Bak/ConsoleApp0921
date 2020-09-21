using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class swap2
    {
        static void ChangeWorld(ref string arg)
        {
            arg = "World";
        }
        static void ChangeWorld(string arg)
        {
            arg = "World";
        }
        static void Main()
        {
            string str = "Hello";
            ChangeWorld(str);   //call by value
            Console.WriteLine(str);

            ChangeWorld(ref str);   //call by reference
            Console.WriteLine(str);

        }
    }
}
