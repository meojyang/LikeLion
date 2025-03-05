using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask6
{

    public class Unit
    {
        protected string Name;
        protected int level;
        protected int Health;
        protected int HealthRegeneration;
        protected int Mana;
        protected int ManaRegeneration;        
        protected int AttackDamage;        
        protected int AbillityPower;
        protected float AttackSpeed;
        protected int CriticalPercent;
        protected int MovingSpeed;
        protected int Armor;
        protected int MagicResistance;
        protected int AbillityHaste;
        protected int Range;
        public Skill[] skills = new Skill[5];



        public Unit()
        {
            Name = "DefaultName";
            level = 0;
            Health = 0;
            HealthRegeneration = 0;
            Mana = 0;
            ManaRegeneration = 0;
            CriticalPercent = 0;
            MovingSpeed = 0;
            AttackDamage = 0;
            AttackSpeed = 0.0f;
            AbillityPower = 0;
            Armor = 0;            
            AbillityHaste = 0;
            Range = 0;
            
        }

        public virtual void MeleeAttack()
        {
            Console.WriteLine($"{Name} 기본 공격 모션 출력");
        }

        public virtual void CriticalAttack()
        {
            Console.WriteLine($"{Name} 치명타 모션 출력");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }

        public virtual void Recall()
        {
            Console.WriteLine($"{Name} 귀환 모션 출력");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"[{Name}]의 정보");
            Console.WriteLine();
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"체력: {Health}\t마나:{Mana}");
            Console.WriteLine($"체력재생: {HealthRegeneration}\t마나재생: {ManaRegeneration}");
            Console.WriteLine($"공격력: {AttackDamage}\t주문력: {AbillityPower}");
            Console.WriteLine($"공격속도: {AttackSpeed:F2}\t치명타율: {CriticalPercent}%");
            Console.WriteLine($"방어력: {Armor}\t마법저항력: {MagicResistance}");
            Console.WriteLine($"사거리: {Range}\t이동속도:{MovingSpeed}");            
        }

    }

    public class TwistedFate : Unit
    {
        public Skill[] skills = new Skill[]
        {
            new Skill("사기 주사위"),
            new Skill("와일드카드", 60, 6),
            new Skill("카드 뽑기", 50, 6),
            new Skill("속임수 덱"),
            new Skill("운명", 100, 180)
        };

        public TwistedFate()
        {
            Console.WriteLine("행운의 여신이 내게 미소를 짓는군.");

            Name = "트위스티드 페이트";
            level = 1;
            Health = 604;
            HealthRegeneration = 5;
            Mana = 333;
            ManaRegeneration = 8;
            CriticalPercent = 0;
            MovingSpeed = 330;
            AttackDamage = 52;
            AttackSpeed = 0.625f;
            AbillityPower = 0;
            Armor = 21;
            MagicResistance = 30;            
            Range = 525;
        }

        public override void Move()
        {
            Console.WriteLine("카드에 다 쓰여있지.");
        }
    }

    public class Garen : Unit
    {
        public Skill[] skills = new Skill[]
        {
            new Skill("인내심"),
            new Skill("결정타", 0, 23),
            new Skill("용기", 50, 6),
            new Skill("심판",0,9),
            new Skill("데마시아의 정의", 0, 180)
        };

        public Garen()
        {
            Console.WriteLine("내 검과 심장은 데마시아의 것이다!");

            Name = "가렌";
            level = 1;
            Health = 604;
            HealthRegeneration = 5;
            Mana = 333;
            ManaRegeneration = 8;
            CriticalPercent = 0;
            MovingSpeed = 330;
            AttackDamage = 52;
            AttackSpeed = 0.625f;
            AbillityPower = 0;
            Armor = 21;
            MagicResistance = 30;
            Range = 525;
        }

        public override void Move()
        {
            Console.WriteLine("두려워마라, 내가 간다!");
        }
    }

    public class Zilean : Unit
    {
        public Skill[] skills = new Skill[]
        {
            new Skill("시간의 호리병"),
            new Skill("시한 폭탄", 60, 10),
            new Skill("되감기", 35, 1),
            new Skill("시간 왜곡", 50,15),
            new Skill("시간 역행", 125, 120)
        };

        public Zilean()
        {
            Console.WriteLine("그리 할 줄 알고 있었소.");

            Name = "질리언";
            level = 1;
            Health = 604;
            HealthRegeneration = 5;
            Mana = 333;
            ManaRegeneration = 8;
            CriticalPercent = 0;
            MovingSpeed = 330;
            AttackDamage = 52;
            AttackSpeed = 0.625f;
            AbillityPower = 0;
            Armor = 21;
            MagicResistance = 30;
            Range = 525;
        }

        public override void Move()
        {
            Console.WriteLine("시간이 허비되고 있소.");
        }
    }

    public class Skill
    {
        public string SkillName;
        public int ManaCost;
        public int Cooldown;

        public Skill(string skillName, int manaCost, int cooldown)
        {
            SkillName = skillName;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000;
        }

        public Skill(string skillName)
        {
            SkillName = skillName;
        }

        public void Use()
        {
            Console.WriteLine($"{SkillName}!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> champions = new List<Unit>();

            champions.Add(new TwistedFate());
            champions.Add(new Garen());
            champions.Add(new Zilean());
            Console.WriteLine();

            foreach(var champion in champions)
            {
                champion.Move();
                champion.MeleeAttack();
                Console.WriteLine();                
            }

            TwistedFate tf = new TwistedFate();
            tf.skills[1].Use();
            Console.WriteLine();

            Garen garen = new Garen();
            garen.skills[4].Use();
            Console.WriteLine();

            Zilean z = new Zilean();
            z.skills[4].Use();
            
        }
    }
}
