using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Class2
    {
        static int Divice(int x, int y, out int mod)    //리턴이 2개 이상일 때 out or ref파라미터로 참조 값을 받아서 연산 -->> x % y, x / y리턴
        {
            mod = x % y;
            return x /y;
        }

        static void Main()
        {
            int x = 13;
            int y = 21;
            int mod;

            Console.WriteLine("몫 : " + Divice(x, y, out mod) + "\t나머지 : " + mod);
        }
    }
}
