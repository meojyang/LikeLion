using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask3
{
    class Program
    {
        static void Main(string[] args)
        {



            // 1. 세 정수의 최댓값 구하기

            int x = 0, y = 0, z = 0;
            int max = 0;
            Console.Write("첫번째 정수를 입력해주세요: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력해주세요: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수를 입력해주세요: ");
            z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                max = (x > z) ? x : z;
            }
            else if (y > x)
            {
                max = (y > z) ? y : z;
            }
            else if (z > x)
            {
                max = (z > y) ? z : y;
            }

            Console.WriteLine("최대값: " + max);


            /*// 2. 점수에 따른 학점 평가

            int score;
            Console.Write("점수를 입력해주세요: ");
            score = int.Parse(Console.ReadLine());


            if (score >= 90)
            {
                Console.WriteLine("A 학점");

            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/


            /*// 3. 간단한 사칙연산 계산기

            int x = 0, y = 0;
            int result = 0;
            string mark = default;

            Console.Write("첫번째 숫자를 입력해주세요: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력해주세요: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("연산 기호를 입력해주세요. (+,-,*,/ 중 하나): ");
            mark = Console.ReadLine();

            if (mark.Equals("+"))
            {
                result = x + y;
            }
            else if (mark.Equals("-"))
            {
                result = x - y;
            }
            else if (mark.Equals("*"))
            {
                result = x * y;
            }
            else if (mark.Equals("/"))
            {
                if (y.Equals(0))
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                }
                else
                {
                    result = x / y;
                }
            }

            Console.WriteLine("결과: " + result);*/

        }
    }
}
