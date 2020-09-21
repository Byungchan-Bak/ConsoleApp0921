using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    public class Kilogram
    {
        double mass;

        public Kilogram(double value)   //기본 생성자
        {
            this.mass = value;
        }

        public Kilogram Add(Kilogram target)    //Kilogram타입의 메서드(Kilogram타입의 파라미터)
        {
            return new Kilogram(this.mass + target.mass);   //kg합산 메서드
        }

        public override string ToString()   //ToString재정의
        {
            //return base.ToString();
            return $"{mass}kg";
        }

        public static Kilogram operator +(Kilogram k1, Kilogram k2) //Operator 연산자 오버로드 메서드(static필수!!)
        {
            return new Kilogram(k1.mass + k2.mass);
        }
    }
    class ExClass2
    {
        static void Main()
        {
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1.Add(kg2);    //합산 메서드
            Console.WriteLine(kg3);
            Kilogram kg4 = kg1 + kg2;   //Operator 연산자 오버로드 메서드
            Console.WriteLine(kg4);
        }
    }
}
