﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion28_2
{
    class Player
    {
        public string name { get; set; }

        public void Render()
        {
            Console.WriteLine("플레이어 : " + name);
        }
    }

    class Wizard : Player
    {
        public string job;

        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();

            p.name = "홍길동";
            p.Render();

            Wizard w = new Wizard();
            w.name = "대마법사";
            w.job = "마법사";
            w.Render();
            w.Render2();
        }
    }
}
