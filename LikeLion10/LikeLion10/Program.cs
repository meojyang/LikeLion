using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.SetWindowSize(80, 25);                  //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);                  //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)

            Console.CursorVisible = false;                  //커서 숨기기

            Console.Clear();                                //화면 지우기

            Console.SetCursorPosition(0, 0);


            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────┐");
            for (int i = 1; i <= 19; i++)
            {

                if (i == 10)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("│                       집으로 가는 지렁이                            │");
                }
                else
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("│                                                                     │");
                }
            }
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────┘");

            Thread.Sleep(3000);

            Console.Clear();

            Console.SetCursorPosition(1, 10);
            Console.Write("○◎");
            Console.SetCursorPosition(0, 9);
            Console.Write("방");
            Thread.Sleep(100);
            Console.Write("향");
            Thread.Sleep(100);
            Console.Write("키");
            Thread.Sleep(100);
            Console.Write("를");
            Thread.Sleep(100);
            Console.Write(" 이");
            Thread.Sleep(100);
            Console.Write("용");
            Thread.Sleep(100);
            Console.Write("하");
            Thread.Sleep(100);
            Console.Write("여");
            Thread.Sleep(100);
            Console.Write(" 움");
            Thread.Sleep(100);
            Console.Write("직");
            Thread.Sleep(100);
            Console.Write("이");
            Thread.Sleep(100);
            Console.Write("세");
            Thread.Sleep(100);
            Console.Write("요");
            Thread.Sleep(100);
            Console.Write("!");
            Thread.Sleep(300);

            Console.Clear();
            Console.SetCursorPosition(1, 10);
            Console.Write("○◎");
            Console.SetCursorPosition(0, 9);
            Console.Write("S");
            Thread.Sleep(100);
            Console.Write("T");
            Thread.Sleep(100);
            Console.Write("A");
            Thread.Sleep(100);
            Console.Write("R");
            Thread.Sleep(100);
            Console.Write("T");
            Thread.Sleep(100);
            Console.Write("!");
            Thread.Sleep(400);

            ConsoleKeyInfo c;
            int x = 1;
            int y = 10;

            int a = x - 1;
            int b = y;

            bool twinkle = true;
            bool isHave = false;
            char answer = '0';

            while (true)
            {
                c = Console.ReadKey();

                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("◎");
                Console.SetCursorPosition(a, b);
                Console.Write("○");
                Console.SetCursorPosition(70, 15);
                Console.Write("▲");
                Console.SetCursorPosition(70, 16);
                Console.Write("■");

                if (isHave == false)
                {
                    if (twinkle)
                    {
                        Console.SetCursorPosition(20, 8);
                        Console.Write("☆");
                        twinkle = false;
                    }
                    else
                    {
                        Console.SetCursorPosition(20, 8);
                        Console.Write("★");
                        twinkle = true;
                    }
                }

                switch (c.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        a = x;
                        b = y + 1;
                        break;

                    case ConsoleKey.DownArrow:
                        y++;
                        a = x;
                        b = y - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        x++;
                        a = x - 1;
                        b = y;
                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        a = x + 1;
                        b = y;
                        break;
                }

                if (x < 0) x++;
                if (x > 79) x--;
                if (y > 25) y--;
                if (y < 1) y++;

                if (isHave == false)
                {
                    if (x == 20 && y == 8)
                    {
                        Console.SetCursorPosition(20, 6);
                        Console.Write("Key 획득!");
                        isHave = true;
                    }
                }

                if (x == 70 && y == 16)
                {
                    Console.SetCursorPosition(20, 10);
                    Console.Write("집");
                    Thread.Sleep(100);
                    Console.Write("으");
                    Thread.Sleep(100);
                    Console.Write("로");
                    Thread.Sleep(100);
                    Console.Write(" 들");
                    Thread.Sleep(100);
                    Console.Write("어");
                    Thread.Sleep(100);
                    Console.Write("갈");
                    Thread.Sleep(100);
                    Console.Write("까");
                    Thread.Sleep(100);
                    Console.Write("요");
                    Thread.Sleep(100);
                    Console.Write("?");
                    Thread.Sleep(100);
                    Console.Write("y");
                    Thread.Sleep(100);
                    Console.Write("/");
                    Thread.Sleep(100);
                    Console.Write("n");
                    Thread.Sleep(100);

                    Console.SetCursorPosition(33, 11);
                    answer = char.Parse(Console.ReadLine());

                    break;

                }

            }

            Console.Clear();

            if (answer == 'y' && isHave == true)
            {

                for (int i = 0; i < 100; i++)
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.Write("무사히 집에 도착했네요!");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("다음에도 또 데려다 주세요!");
                    Console.SetCursorPosition(10, 10);
                    Console.Write("○");
                    Console.SetCursorPosition(10, 9);
                    Console.Write("◎");
                    Thread.Sleep(300);

                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.Write("무사히 집에 도착했네요!");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("다음에도 또 데려다 주세요!");
                    Console.SetCursorPosition(10, 11);
                    Console.Write("○");
                    Console.SetCursorPosition(10, 9);
                    Console.Write("◎");
                    Thread.Sleep(300);

                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.Write("무사히 집에 도착했네요!");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("다음에도 또 데려다 주세요!");
                    Console.SetCursorPosition(10, 11);
                    Console.Write("○");
                    Console.SetCursorPosition(10, 10);
                    Console.Write("◎");
                    Thread.Sleep(300);

                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.Write("무사히 집에 도착했네요!");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("다음에도 또 데려다 주세요!");
                    Console.SetCursorPosition(10, 11);
                    Console.Write("○");
                    Console.SetCursorPosition(10, 9);
                    Console.Write("◎");
                    Thread.Sleep(300);

                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.Write("무사히 집에 도착했네요!");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("다음에도 또 데려다 주세요!");
                    Console.SetCursorPosition(10, 10);
                    Console.Write("○");
                    Console.SetCursorPosition(10, 9);
                    Console.Write("◎");
                    Thread.Sleep(300);

                }
            }
            else
            {
                Console.SetCursorPosition(20, 15);
                Console.Write("아무래도 집에 오는 길에 무언가 깜빡한 것 같아요...");
            }
        }
    }
}
