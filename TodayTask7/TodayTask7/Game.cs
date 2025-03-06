using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask7
{
    class Game
    {
        Field f = null;
        Player p = null;
        public void Init()
        {
            p = new Player(); //게임 시작됐으니 플레이어 생성
            p.SelectJob(); //플레이어 직업 선택하게 하기
        }

        public void Progress()
        {
            while (true)
            {
                Console.Clear(); //화면 싸@악 지워주고
                p.Render(); //플레이어 쌈@뽕하게 그려주고
                Console.WriteLine("1. 사냥터  2.종료");
                int input = 0;
                input = int.Parse(Console.ReadLine());

                /*if(input == 2) break;

                if(input == 1)
                {
                    if (f == null)
                    {
                        f = new Field();
                        f.SetPlayer(p);
                    }

                }*/
            }
        }

        public Game() { }
        ~Game() { }
    }
}
