using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion20
{
    //클래스

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("민수", 20);
            p.Greet();

            Person p2 = new Person("철수", 5);
            p2.Greet();
        }
    }

    class Person
    {
        public string Name;
        public int Age;
        //기본 생성자
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메소드
        //생성자는 클래스와 같은 이름이며, 반환형이 존재 X
        //객체 초기값을 설정할때 많이 사용한다.

        public Person(string str, int age)
        {
            Name = str;
            Age = age;
            Console.WriteLine("매개변수가 있는 생성자 실행");
        }

        public void Greet() => Console.WriteLine($"제 이름은 {Name}, {Age}살이에요.");
    }
}
