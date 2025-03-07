using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAttack
{
    public class Unit
    {
        /*//각각의 유닛은 이름과 생명력, 공격력을 가진다.
        public string Name;
        public int Hp;
        public int Attack;*/
        public INFO Uinfo;

        //데미지를 입는 함수
        public void GetDamage(int damage) { Uinfo.Hp -= damage; }
        
        public INFO GetInfo() { return Uinfo; }
                
        //체력을 설정하는 함수
        public void SetHp(int hp) { Uinfo.Hp = hp; }

        //유닛을 그리는 함수
        //오버라이딩해서 쓸거니까 virtual
        public virtual void Render()
        {
            Console.WriteLine("====================");
            Console.WriteLine("생명력 : " + Uinfo.Hp + "\t공격력 : " + Uinfo.Attack);
        }

        public Unit() { }
        ~Unit() { }
    }
}
