using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame game = new MainGame(); //게임 객체 생성
            game.Initialize(); //플레이어 객체도 생성하고 직업선택하게 하기

            game.progress(); //게임 진행시키기

        }
    }
}
