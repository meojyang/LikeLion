using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TimeAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMain gm = new GameMain();

            gm.Init(); //게임 메인 생성
            gm.Progress(); //게임 메인의 진행과정
        }
    }
}
