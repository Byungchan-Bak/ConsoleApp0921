using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp0921
{
    class Swap
    {
        //static int x = 3;
        //static int y = 5;
        /*
        static void swap(out int x, out int y)  //값이 할당되지 않아도 넘어옴
        {
            int temp;

            temp = x;
            x = y;
            y = temp;

            //Console.WriteLine("x = {0} // y = {1}", x, y);
        }
        */
        /*
        static void swap(ref int x, ref int y)  //값이 할당되어 넘어옴
        {
            int temp;

            temp = x;
            x = y;
            y = temp;

            //Console.WriteLine("x = {0} // y = {1}", x, y);
        }
        */
        static void swap(int x, int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;

            //Console.WriteLine("x = {0} // y = {1}", x, y);
        }

        public Swap()
        {

        }
        static void Main()
        {
            int[] x_arr = new int[2] { 3, 5 };
            //int x = 3;
            //int y = 5;

            Console.WriteLine("x = {0} // y = {1}", x_arr[0], x_arr[1]);
            swap(x_arr[0], x_arr[1]);

            Console.WriteLine("x = {0} // y = {1}", x_arr[0], x_arr[1]);
            /*
            swap(ref x_arr[0], ref x_arr[1]);
            Console.WriteLine("x = {0} // y = {1}", x_arr[0], x_arr[1]);
            */
            /*
            swap(out x_arr[0], out x_arr[1]);
            Console.WriteLine("x = {0} // y = {1}", x_arr[0], x_arr[1]);
            */

            string str = "10";
            int num;
            if(!int.TryParse(str, out num))
            {
                num = 0;
            }
        }
    }
}
