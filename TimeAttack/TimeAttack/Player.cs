using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAttack
{
    public class Player : Unit
    {
        
        public void SelectClass()
        {
            Uinfo = new INFO();
            Console.WriteLine("직업을 선택하세요(1. 기사  2. 마법사  3. 도둑)");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Uinfo.Name = "기사";
                    Uinfo.Hp = 100;
                    Uinfo.Attack = 10;
                    break;
                case 2:
                    Uinfo.Name = "마법사";
                    Uinfo.Hp = 75;
                    Uinfo.Attack = 15;
                    break;
                case 3:
                    Uinfo.Name = "기사";
                    Uinfo.Hp = 85;
                    Uinfo.Attack = 13;
                    break;
            }
        }


        public override void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("직업이름 : " + Uinfo.Name);
            Console.WriteLine("생명력: " + Uinfo.Hp + "\t공격력: " + Uinfo.Attack);
        }


        public Player() {}
        ~Player() { }
    }
}
