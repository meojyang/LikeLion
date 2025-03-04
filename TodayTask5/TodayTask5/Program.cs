using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask5
{
    /*public class Warrior
    {
        public string Name;
        public int Score;
    }

    public class Warrior2 : Warrior
    {
        public int Strength;
    }*/


    class Program
    {
        static void Main(string[] args)
        {
            // 1.warrior 클래스 만들고 속성 추가해 출력하기
            /*Warrior2 man = new Warrior2();
            Console.WriteLine("전사 생성");
            man.Name = "맨";
            man.Score = 100;
            man.Strength = 100;

            Console.WriteLine($"전사의 이름: {man.Name}");
            Console.WriteLine($"전사의 점수: {man.Score}");
            Console.WriteLine($"전사의 힘: {man.Strength}");*/

            /*// 2. 정수 입력받고 int로 변환하는 프로그램
            // 숫자로 변환할 수 없으면 예외처리하여 에러 메시지 출력
                        
                Console.Write("숫자를 입력하세요: ");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요!");                    
                }*/


            /*//3. 컬렉션 활용
            List<string> list = new List<string>();
            list.Add("사과");
            list.Add("바나나");
            list.Add("포도");

            foreach(var fruits in list)
            {
                Console.WriteLine(fruits);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            foreach (var task in queue)
            {
                Console.WriteLine(task);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*//4.문자열처리

            Console.Write("문자열 입력: ");
            string greeting = Console.ReadLine();
            greeting = greeting.ToUpper();
            Console.WriteLine(greeting);          
            Console.WriteLine(greeting.Replace("#", "sharp"));
            Console.WriteLine(greeting.Replace("#", "sharp").Length);*/

            //5.LINQ
            
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = numbers.Sum();

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
