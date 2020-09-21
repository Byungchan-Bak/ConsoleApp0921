using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Time Clock1 = new Time(18, 62);
            Console.WriteLine(Clock1.ToString());

            Time Clock2 = new Time(19, 2);
            Console.WriteLine(Clock1.Equals(Clock2));

            Clock1++;
            Console.WriteLine(Clock1.ToString());

            Time Clock3 = Clock1 + Clock2;
            Console.WriteLine(Clock3.ToString());
        }
    }

    class Time
    {
        private int hours, minutes;

        public Time()
        {
            Examine();
        }

        public Time(int hours, int minutes) //기본 생성자(2파라미터)
        {
            this.minutes = minutes;
            this.hours = hours;
            Examine();  //시간 설정 메서드
        }

        public Time(int minutes)    //기본 생성자(1파라미터)
        {
            this.minutes = minutes;
            Examine();
        }

        private void Examine()  //노출될 필요 없는 Private메서드
        {
            hours = hours % 24 + minutes / 60;
            minutes %= 60;
        }

        public override string ToString()   //ToString 재정의
        {
            //return base.ToString();
            Examine();
            return $"현재시각 -->> {this.hours} : {this.minutes}";
        }

        public override bool Equals(object obj) //두 시간 값을 비교하기 위한 Equals 재정의
        {
            return obj is Time time &&  //obj가 Time이고, hour과 minutes값이 같으면 true반환
                   hours == time.hours &&
                   minutes == time.minutes;
        }

        private int TotalMinutes()
        {
            return hours * 60 + minutes;    //시간 비교를 위하여 시간의 분화
        }

        public static Time operator + (Time t1, Time t2)    //연산자 오버로드
        {
            return new Time(t1.TotalMinutes() + t2.TotalMinutes()); //두 시간의 합
        }

        public static Time operator ++(Time t1)
        {
            return new Time(t1.TotalMinutes() + 1); //시간의 증가
        }

        public static bool operator >(Time t1, Time t2) //부등호 연산자 오버로드 시 반대되는 연산자도 오버로드
        {
            return t1.TotalMinutes() > t2.TotalMinutes();
        }
        public static bool operator <(Time t1, Time t2)
        {
            return t1.TotalMinutes() < t2.TotalMinutes();
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
