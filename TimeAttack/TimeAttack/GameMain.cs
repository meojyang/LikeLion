using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAttack
{
    public class GameMain
    {
        public Player p = null;
        public Field f = null;

        public void Init() { //게임 실행 처음에만 Init을 하면서 player 객체를 만들어줄거기 때문에
            //굳이 if(p == null)같은걸 쓸필요는 없음
            p = new Player();
            p.SelectClass();
        }

        public void Progress()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                p.Render();
                Console.WriteLine("1. 사냥  2. 종료");
                input = int.Parse(Console.ReadLine());

                if(input == 2) break; //2번을 누르면 게임 종료

                if(input == 1) //사냥을 하러간다 했을때
                {
                    if (f == null) //필드가 비어있다면
                    {
                        f = new Field(); //필드 객체를 새로 생성
                        f.SetPlayer(ref p); //필드에 플레이어를 세팅 해주고
                    }
                    
                    f.Progress(); //그리고 나서 필드에서 할일을 진행시키면 됨

                }
            }
        }
    }
}
