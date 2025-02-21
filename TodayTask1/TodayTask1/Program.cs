using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //텍스트 노벨 만들기
            string userName;
            int num;
            int result;

            Console.WriteLine("엔터키를 누르면 시작합니다!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Loading...□□□□□");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading...■□□□□");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading...■■□□□");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading...■■■□□");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading...■■■■□");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Loading...■■■■■");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Load Complete!");
            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("당신의 이름을 입력해주세요: ");
            userName = Console.ReadLine();
            Console.WriteLine($"환영합니다, {userName}.");
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine($"{userName}씨의 생각을 알아맞추는 간단한 마술을 해볼겁니다.\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("0부터 9까지의 수 중 하나를 골라 기억해주세요.\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("기억하셨나요? 그럼, 그 수에 2를 더해주세요.\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그리고 5를 곱한 후, 15를 더해주세요.\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("다시 그 수에 2를 곱해주세요.\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그리고 나온 숫자를 말해주세요.");
            Console.Write("나온 숫자는? : ");
            num = int.Parse(Console.ReadLine());
            result = (num / 10) - 5;
            Console.Clear();

            Console.Write("흠.");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("흠..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("흠...");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine($"{userName}씨가 생각한 숫자는... {result}!\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("어때요? 맞나요?\n(엔터를 눌러 다음 문장으로)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("정확히 맞춰서 놀라셨다면... 다시 한 번 이 곳을 찾아주세요.\n(엔터를 눌러 종료)");
            Console.ReadLine();

            /*int delaytime = 150;
            Console.Write("여");
            Thread.Sleep(delaytime);
            Console.Write("긴");
            Thread.Sleep(delaytime);
            
            Console.Write("어");
            Thread.Sleep(delaytime);
           
            Console.Write("디");
            Thread.Sleep(delaytime);
        
            Console.Write("지");
            Thread.Sleep(delaytime);
         
            Console.Write(".");
            Thread.Sleep(delaytime);
     
            Console.Write(".");
            Thread.Sleep(delaytime);
      
            Console.Write(".");
            Thread.Sleep(delaytime);
            Console.Write("?");*/
            //타자기 스타일 연습
        }
    }
}
