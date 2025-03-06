using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{

    //인터페이스를 활용하면 객체가 어떤 특정한 동작을 보장하면서도 다양한 형태로 사용 가능
    //여러 동물을 공통된 방식으로 다룰 수 있다.

    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("멍멍!");
        }
    }


    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("야옹!");
        }
    }

    //인터페이스를 활용한 공통메소드

    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.WriteLine("동물이 소리를 냅니다.");
            animal.Speak();
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            AnimalTrainer at = new AnimalTrainer();
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            at.Train(dog);
            at.Train(cat);

        }
    }
}
//새로 어떤 동물이 생기더라도 Train 메소드를 변경할 필요가 없음
