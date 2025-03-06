using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Monster : Unit
    {
                        
        public void SetMonster(INFO tMonster) { info = tMonster; }
               
        public override void Render()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("몬스터 이름: " + info.strName);
            Console.WriteLine("체력: " + info.iHp + "\t공격력 : " + info.iAttack);
        }

        public Monster() { }
        ~Monster() { }
    }
}
