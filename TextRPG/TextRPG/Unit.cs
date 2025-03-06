using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Unit
    {
        public INFO info;
        //데미지를 입는 함수
        public void SetDamage(int iAttack) { info.iHp -= iAttack; }
        
        //정보를 외부로 가져갈 수 있는 함수
        public INFO GetInfo() { return info; }
        
        //hp를 설정하는 함수
        public void SetHp(int iHp) { info.iHp = iHp; }
        

        //유닛을 그리는 함수
        public virtual void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("체력: " + info.iHp + "공격력: " + info.iAttack);
        }

        public Unit() { }
        ~Unit() { }

    }
}
