using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Factorial(5));
        }

        //params 키워드 (가변 매개변수)

        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }


        //재귀함수 (자기 자신을 호출

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*" + n);
                return 1;
            }
            else
            {
                Console.WriteLine("*" + n);
                return n * Factorial(n - 1);
            }
        }

    }
}
