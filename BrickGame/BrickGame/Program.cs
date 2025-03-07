using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]

        public static extern int __getch(); //c언어 함수 가져옴

        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            GameManager gm = new GameManager();
            gm.Initialize();

            int Curr = Environment.TickCount;

            while (true)
            {
                if(Curr + 50 < Environment.TickCount) //0.5초 지나면
                {
                    Curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }
            


        }
    }
}
