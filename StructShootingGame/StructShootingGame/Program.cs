using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        struct Player
        {
            public int playerX;
            public int playerY;
            public string[] plane;

            public Player(int playerX, int playerY)
            {
                this.playerX = playerX;
                this.playerY = playerY;
                plane = new string[]
                {
                    "*^ ^*",
                    "->",
                    "--|>",
                    "->"
                };
            }

            public void Draw()
            {
                for (int i = 0; i < plane.Length; i++)
                {
                    //콘솔 좌표에서의 플레이어의 x,y좌표를 움직여 줄것
                    Console.SetCursorPosition(playerX, playerY + i);
                    //플레이어 문자열 배열 출력
                    Console.WriteLine(plane[i]);
                }
            }

            public void Move(ConsoleKey key)
            {
                switch (key)
                {
                    //콘솔에서는 y좌표가 커질수록 아래로 가기때문에
                    //화살표 위키를 누르면 y값을 줄여 위로 올라가게 한다
                    //0보다 작아지면 오버플로우가 나기때문에 0보다 클때만 줄인다

                    case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                    case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                    case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                    case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일"); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Player p1 = new Player(0, 12);

            

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            /*int playerX = 0;
            int playerY = 12;*/

            //1초짜리 시간 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간

                if (currentSecond - prevSecond >= 100)
                {
                    
                    prevSecond = currentSecond; //이전 시간 업데이트

                    Console.Clear();

                    keyInfo = Console.ReadKey(true);


                    p1.Move(keyInfo.Key);
                    p1.Draw();
                }
            }
        }
    }
}
