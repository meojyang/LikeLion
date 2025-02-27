using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion13
{
    class Program
    {

        //1.매개변수도 반환값도 없는 함수

        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        //2. 매개변수만 있는 함수

        static void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        //3. 반환값만 있는 함수

        static int GetNum()
        {
            return 42;
        }

        //4. 매개변수와 반환값 둘다 있는 함수

        static int Add(int a, int b)
        {
            return a + b;

        }

        //5. 기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}.");
        }

        //6. 함수 오버로딩(Overloading)

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        //함수의 기능은 같으나 반환값과 입력값의 자료형만 바꾸고 싶을때 오버로딩이 가능하다
        //같은 이름을 쓰는것이 가능하다는 말

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //7.  out 키워드 ( 여러값을 반환할때)
        //함수의 리턴을 여러개 주고싶을때
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
            
        }

        //8.ref 키워드 (값을 참조하여 수정)

        static void Increase(ref int num)
        {
            num += 10;
        }

        static void Main(string[] args)
        {
            //PrintHello();
            //PrintMessage("반갑습니다");

            //int num = GetNum();

            //Console.WriteLine(num);

            //int result = Add(3, 5);

            //Console.WriteLine(result);
            // Greet();
            //Greet("철수");

            /*int q, r;

            Divide(10, 3, out q, out r);

            Console.WriteLine($"몫: {q}, 나머지: {r}");
            */

            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);
        }
    }
}
