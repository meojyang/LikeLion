using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion31
{
    class Program
    {

        //C의 포인터개념을 참조하는것과 비슷
        //ref와 out 메소드

        static void Increase(ref int x)
        {
            x++;
        }


        //반환을 여러개 처리하고싶을때 유용한 out 메소드

        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {

            /*int a = 10;
            Increase(ref a);
            //ref를 안쓰면 Increase에 넣어도 그냥 위에서 처리하고 사라지는데
            //ref를 쓰면 증가한값이 메인으로 잘 전달이 된다
            Console.WriteLine(a);*/

            int a = 10, b = 20;
            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine($"x: {x}, y: {y}");

        }
    }
}
