using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAttack
{
    public class Monster : Unit
    {                   

        public void SetMonster(INFO m_info) { Uinfo = m_info; }

        public override void Render()
        {
            Console.WriteLine("====================");
            Console.WriteLine("몬스터 이름: " + Uinfo.Name);
            Console.WriteLine("생명력 : " + Uinfo.Hp + "\t공격력 : " + Uinfo.Attack);
        }

        public Monster() { }
        ~Monster() { }
    }
}
