using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//배열
            //0부터 시작함

            int[] num = new int[3]; //3개의 int형 변수가 들어갈 수 있는 배열 선언

            // new 명령어를 통해 새로운 객체를 생성

            num[0] = 10; // 배열의 첫번째 요소를 10으로 초기화
            num[1] = 20; // 배열의 두번째 요소를 20으로 초기화
            num[2] = 30; // 배열의 세번째 요소를 30으로 초기화

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]); // 배열의 i번째 요소를 출력해라
            }*/

            /* // 다양한 방법으로 배열을 선언할 수 있다.

             int[] num = { 1, 2, 3 }; // 심플하게 생성
             int[] num2 = new int[3]; // 크기만 지정해서 생성 //모든요소가 0으로 초기화되어 생성됨
             int[] num3 = new int[] { 1, 2, 3 }; //크기는 지정 않고 요소를 지정 // 제일 비효율적인듯...

             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine(num3[i]); // 배열의 i번째 요소를 출력해라*/


            /*//숫자 뿐만 아니라 문자열도 배열 선언이 가능하다

            string[] fruits = { "apple", "banana", "kiwi" };

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/



            /*// 3명의 국어 영어 수학 점수를 입력받고
            // 총점과 평균 출력하기

            int[] sum = new int[3];
            float[] average = new float[3];

            int[] korScore = new int[3];
            int[] engScore = new int[3];
            int[] mathScore = new int[3];
        
            for (int i = 0; i < 3; i++)
            {

         
                Console.Write("국어 점수를 입력해주세요: ");                   
                korScore[i] = int.Parse(Console.ReadLine());     
                Console.Write("영어 점수를 입력해주세요: ");
                engScore[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 점수를 입력해주세요: ");
                mathScore[i] = int.Parse(Console.ReadLine());
            
                sum[i] = korScore[i] + engScore[i] + mathScore[i];
                average[i] = (float)sum[i] / 3;
            }                         

            for(int k = 0; k < 3; k++)
            {
                Console.WriteLine((k + 1) + "번 학생");
                Console.WriteLine("========================");
                Console.WriteLine("총점: " + sum[k]);
                Console.WriteLine("평균: " + average[k]);
                Console.WriteLine("========================");
            }*/

            /*//1차원 배열 복습

            int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 75;

            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + 1}: {scores[i]}");
            }*/


            /*double val = 123.456789;
            double val2 = 123123213123123.123123312213;

            Console.WriteLine(val.ToString("F2"));
            Console.WriteLine($"소수점 둘째 자리 : {val:F2}");
            Console.WriteLine(String.Format("소수점 둘째 자리: {0:F2}", val));
            
            //소수점 없이 출력하려면?
            Console.WriteLine(val.ToString("F0"));

            //천단위로 반점 찍어주려면?
            Console.WriteLine(val2.ToString("N2"));*/


            /*//2차원 배열 선언
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }*/



            /*// 가변 배열

            int[][] jaggedarr = new int[3][];

            jaggedarr[0] = new int[] { 1, 2, 3, };
            jaggedarr[1] = new int[] { 4, 5, 6,7 };
            jaggedarr[2] = new int[] { 7, 8, 9,10,11,12 };

            for(int i=0; i<jaggedarr.Length; i++)
            {
                for(int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedarr[i][j]}");
                }
            }
           
            Console.WriteLine(jaggedarr[0].Length);
            */

            /*Console.WriteLine("var 키워드 사용");
            var nums = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {nums.GetType()}");*/


            
        }
     }
}
