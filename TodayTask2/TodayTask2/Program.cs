using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int korScore = 0, engScore = 0, mathScore = 0;
            int sum = 0;
            float average = 0.0f;

            Console.Write("국어 점수 입력: ");
            korScore = int.Parse(Console.ReadLine());
            Console.Write("영어 점수 입력: ");
            engScore = int.Parse(Console.ReadLine());
            Console.Write("수학 점수 입력: ");
            mathScore = int.Parse(Console.ReadLine());

            sum = korScore + engScore + mathScore;

            average = (float)sum / 3;

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + average.ToString("F2"));
*/

            int num = 0;
            int reverseNum = 0;

            Console.Write("정수 입력: ");
            num = int.Parse(Console.ReadLine());
            reverseNum = ~num;

            Console.WriteLine("입력받은 정수: " + num);
            Console.WriteLine("비트 반전 결과: " + reverseNum);
        }
    }
}
