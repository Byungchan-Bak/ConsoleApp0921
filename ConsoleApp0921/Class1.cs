using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    abstract class Person   //추상클래스(클래스 안의 메서드 중 한 개라도 추상일 경우 무조건 추상클래스 선언)
    {
        public abstract void Speak();   //추상메서드 abstract

        public void Work()
        {
            Console.WriteLine("일을 합니다.");
        }

        public void Study()
        {
            Console.WriteLine("공부를 합니다.");
        }
    }
    class Employee : Person //추상클래스를 상속받는 클래스
    {
       public override void Speak() //추상클래스의 추상메서드를 Override를 통해 정의
        {
            Console.WriteLine("Emplyee가 일을 합니다.");
        }
    }
    class Class1
    {
        static void Main()
        {
            Employee p1 = new Employee();   //추상클래스는 new사용이 제한이 되어 자식클래스를 통해 인스턴스를 생성
            //Person p1 = new Person();
            p1.Speak(); //재정의한 메서드 사용
        }
    }
}
