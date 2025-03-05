using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion28
{
    //부모 클래스
    class Animal
    {
        public string Name { get; set; }
        
        public void Eat()
        {
            Console.WriteLine($"{Name}이가 냠냠");
        }
    }

    //자식 클래스
    class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine($"{Name}이 짖습니다, 멍멍!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Eat();
            myDog.Bark();

        }
    }
}
