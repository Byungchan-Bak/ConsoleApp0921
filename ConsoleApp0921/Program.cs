using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    //1. Time클래스 정의
    //2. int hours와 int minutes를 멤버로 생성
    //3. 생성자(hour, minutes)
    class Program
    {
        static void Main(string[] args)
        {
            Time Clock1 = new Time(18, 72);
            Console.WriteLine(Clock1.ToString());

            Time Clock2 = new Time(19, 12);
            Console.WriteLine(Clock1.Equals(Clock2));
        }
    }

    class Time
    {
        private int hours, minutes;

        public Time(int hours, int minutes)
        {
            this.minutes = minutes;
            this.hours = hours;
            Examine();
        }

        private void Examine()
        {
            hours = hours % 24 + minutes / 60;
            minutes %= 60;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"현재시각 -->> {this.hours} : {this.minutes}";
        }

        public override bool Equals(object obj)
        {
            return obj is Time time &&
                   hours == time.hours &&
                   minutes == time.minutes;
        }

        //public static bool operator ==(Time left, Time right)
        //{
        //    return EqualityComparer<Time>.Default.Equals(left, right);
        //}

        //public static bool operator !=(Time left, Time right)
        //{
        //    return !(left == right);
        //}
    }
}
