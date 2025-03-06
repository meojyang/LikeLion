using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player : Unit
    {           
        //직업 선택
        
        public void SelectJob()
        {
            info = new INFO();
            Console.WriteLine("직업을 선택하세요(1. 기사 2. 마법사 3. 도둑)");
            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());

            switch(iInput)
            {
                case 1:
                    info.strName = "기사";
                    info.iHp = 100;
                    info.iAttack = 10;
                    break;
                case 2:
                    info.strName = "마법사";
                    info.iHp = 70;
                    info.iAttack = 15;
                    break;
                case 3:
                    info.strName = "도둑";
                    info.iHp = 85;
                    info.iAttack = 13;
                    break;
            }
        }

        public override void Render()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("직업 이름: " + info.strName);
            Console.WriteLine("체력: " + info.iHp + "\t공격력 : " + info.iAttack);
         }

        public Player() { } //생성자

        ~Player() { } //소멸자
    }
}
