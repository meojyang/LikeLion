using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion28_7
{

    //이 프로젝트를 참고해서
    //롤 클래스를 설계해보기.

    //부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다. ");
        }


        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다. ");
        }
    }

    //SCV유닛 (건설과 수리 기능)
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다.! (공격력이 약함)");
        }


        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다.(기계유닛만 가능)");
        }

    }

    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            base.Attack();
            {
                Console.WriteLine("Marine이 소총으로 공격합니다.");
            }
        }
    }

    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target}을 치료합니다. (생명유닛만 가능)");
        }
    }

    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine($"Tank가 시즈 모드로 공격합니다.");
        }

        public override void Move()
        {
            Console.WriteLine("Destination!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());
            
            foreach(var u in units)
            {
                u.Move();
                u.Attack();
                Console.WriteLine();
               
            }

            SCV scv = new SCV();
            scv.Heal(units[3]);

            Medic medic = new Medic();

            medic.Heal(units[1]);
        }
    }
}