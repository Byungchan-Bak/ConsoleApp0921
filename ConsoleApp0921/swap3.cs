using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Point
    {
        public int x = 13;
        public int y = 21;
    }
    class swap3
    {
        static void swap(Point p1)
        {
            int temp = p1.y;
            p1.y = p1.x;
            p1.x = temp;
        }
        static void Main()
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 2;

            Console.WriteLine($"x= {p1.x} // y={p1.y}");
            //swap(p1);
            //swap(new Point());  
            Point p2 = new Point(); //Deep Copy -->> 새로운 인스턴스를 생성하여 메서드에서 파라미터를 활용하나 참조한 값에는 영향을 미치지 않음.
            p2.x = p1.x;
            p2.y = p1.y;
            swap(p2);
            Console.WriteLine($"x= {p1.x} // y={p1.y}");


        }
    }
}
