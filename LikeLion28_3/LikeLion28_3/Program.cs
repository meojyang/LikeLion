using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion28_3
{

    public class Animal
    {
        public string Name { get; set; }

        public virtual void Speak() //부모 클래스엔 버츄얼을 붙여주고
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak() //자식클래스엔 오버라이드 키워드를 붙여줘야 오버라이딩 가능
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Animal a = new Animal();
            a.Name = "동물";
            a.Speak();

            Dog d = new Dog();
            d.Name = "바둑";
            d.Speak();
        }
    }
}
