using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    public class Currency
    {
        decimal money;
        public decimal Money { get { return money; } }

        public Currency(decimal money)
        {
            this.money = money;
        }
    }
    //원화

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Money}Won";
        }
    }
    //달러
    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) { }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Money}Dollar";
        }
    }
    //엔화
    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public static implicit operator Won(Yen yen)    //Won와 Yen클래스의 형변환을 위하여 Implicit선언
        {
            return new Won(yen.Money * 13m);
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Money}Yen";
        }
    }
    class ExClass3
    {
        static void Main()
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(13);

            //won = yen; -->> 형제관계의 클래스는 타입이 다르기 때문에 불가능

            Won won1 = yen; //암시적 형변환(Implicit)
            Won won2 = (Won)yen;    //명시적 형변환(Explicit) -->> 형변환만 가능하도록 제한
        }
    }
}
