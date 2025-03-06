﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion35
{
    public class Mage : GameCharacter
    {
        public Mage(string name) : base(name, 80, 20, 5)
        {
        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}(이)가 {target.Name}에게 마법구체를 던집니다.");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}(이)가 {target.Name}에게 화염 폭발을 시전합니다.");
            target.TakeDamage(Attack * 2);
        }
    }
}
