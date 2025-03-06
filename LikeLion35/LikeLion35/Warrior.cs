using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeLion35
{
    public class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 150, 15, 15)
        {
        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}(이)가 {target.Name}에게 검을 휘두릅니다.");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}(이)가 {target.Name}에게 건곤대나이~!");
            target.TakeDamage(Attack * 2);
        }
    }
}
