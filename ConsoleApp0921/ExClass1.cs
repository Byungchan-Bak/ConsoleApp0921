using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    public class ExPoint    //ToString Override
    {
        int x, y;

        public ExPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()   //ToString출력 재정의
        {
            //return base.ToString();
            return $"X ->> {x}\t Y-->> {y}";
        }
    }
    class ExClass1  
    {
        static void Main()
        {
            ExPoint pt = new ExPoint(13, 21);
            Console.WriteLine(pt.ToString());   //ExPoint타입의 인스턴스 pt를 생성하여 ToString으로 출력
        }
    }
}
