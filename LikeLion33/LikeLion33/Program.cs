using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion33
{
    //자식클래스는 부모클래스의 생성자를 호출할수있다

    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모 생성자 메시지 : " + message ); //2번째, 부모 생성자 호출 뒤 실행
        }
    }

    class Child : Parent
    {
        public Child():base("성공!") //부모 생성자 호출'
        //base 키워드가 Parent(string message)를 대체한다
        //즉 Parent("성공!")을 호출하는셈
        {
            Console.WriteLine("자식 생성자 호출"); //3번째, 자식 생성자의 메시지
        }
    }

    class Program
    {
        static void Main(string[] args) //1번째 부모 생성자 호출
        {
            Child child = new Child(); //0번째 객체 생성
        }
    }
}
