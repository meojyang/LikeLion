using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask7
{
    class Player : Unit
    {
        INFO p_info = new INFO();
        public void SelectJob()
        {
            
            int input = 0;
            Console.WriteLine("직업을 선택하세요(1. 기사  2.마법사  3. 도둑)");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    p_info.Name = "기사";
                    p_info.Hp = 100;
                    p_info.Attack = 10;
                    break;
                case 2:
                    p_info.Name = "마법사";
                    p_info.Hp = 60;
                    p_info.Attack = 15;
                    break;
                case 3:
                    p_info.Name = "도둑";
                    p_info.Hp = 75;
                    p_info.Attack = 13;
                    break;

            }
        }

        public override void Render()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("직업이름: " +  p_info.Name);
            Console.WriteLine("체력: " + p_info.Hp + "\t공격력: " + p_info.Attack);
        }

    }
}
