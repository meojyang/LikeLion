using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//1. 배열 요소 출력

            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/

            /*//2. 배열 요소 합 구하기
            int[] arr = new int[5];
            int sum = 0;

            Console.Write("정수를 5개 입력해주세요: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
                
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            Console.WriteLine("모든 수의 합은: " + sum);
*/

            /* //3. 배열에서 가장 큰 값 찾아 출력하기
             int[] arr = { 6,2,3,15,8 };
             int max = 0;

             for(int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] > max) max = arr[i];
             }

             Console.WriteLine("최대값은 : " + max);*/


            /* //4. 1부터 10까지 출력
             for(int i = 0; i < 10; i++)
             {
                 Console.Write($"{i +1} ");
             }*/

            /* //5. while문 사용해서 1부터 10까지 짝수만 출력하기
             int i = 0;
             while(i < 11)
             {
                 if (i % 2 == 0) Console.Write($"{i} ");
                 i++;
             }*/

            /*//6. foreach문 사용하여 배열 요소 출력하기

            int[] arr = { 1, 2, 3, 4, 5 };

            foreach(int a in arr)
            {
                Console.Write($"{a} ");
            }*/

            /* //7. 두 수의 합을 반환하는 함수 작성하기
             Console.Write("정수를 2개 입력해주세요: ");
             string input = Console.ReadLine();
             string[] numbers = input.Split(' ');

             int num1 = int.Parse(numbers[0]);
             int num2 = int.Parse(numbers[1]);

             Console.WriteLine($"{num1}과 {num2}의 합: {Add(num1,num2)}");*/

            /*//8. 문자열을 입력받아 길이를 반환하는 함수 작성하기
            Console.Write("문자열 입력: ");
            string input = Console.ReadLine();
            Console.WriteLine("문자열 길이: " + StringLength(input));*/

            /*//9. 세 개의 정수를 입력받아 가장 큰 수를 반환하는 함수

            Console.Write("정수를 3개 입력해주세요: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            Console.WriteLine("가장 큰 수: " + MaxFinder(num1, num2, num3));
*/
        }

        static int MaxFinder(int a, int b, int c)
        {
            int max = 0;
            if (a > max) max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            return max;
        }
            
        static int StringLength(string str)
        {
            return str.Length;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
