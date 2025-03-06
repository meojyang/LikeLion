using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask7
{
    public class Unit
    {
        INFO U_info = new INFO();

        public void SetHp(int hp){ U_info.Hp = hp; }
        public void GetDamage(int attack) { U_info.Hp -= attack; }
        public INFO GetInfo() { return U_info; }

        public virtual void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("체력: " + U_info.Hp + "\t공격력: " + U_info.Attack);
        }

    }
}
