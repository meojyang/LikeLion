using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion36
{
    //인터페이스
    //어떤 기능을 반드시 포함하도록 강제

    //interface 키워드를 사용해서 정의
    //추상 메소드만 포함(구현을 하지 않는다) -> 인터페이스를 구현하는 클래스에서 반드시 구현해야함
    //다중 상속 가능(C#에서는 클래스 다중상속이 불가능하지만 인터페이스는 여러개 상속 가능)

    interface IAnimal
    {
        void MakeSound(); //있다고만 말해주는 정도
    }

    class Dog : IAnimal
    {        
        public void MakeSound()
        {
            Console.WriteLine("woof woof");
        }
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal a = new Dog();

            a.MakeSound();

            IAnimal c = new Cat();
            c.MakeSound();


        }
    }
}
