using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace LikeLion12
{
    class Program
    {

        static void Loading()
        {
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        static void AttackFunction(int att)
        {
            Console.WriteLine("공격력은 : " + att);
        }

        static int BaseAttack()
        {
            //기본 공격력 10
            int baseAttack = 10;
            
            return baseAttack;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            /*int att = 0;
            int baseAtt = 0;

            Console.WriteLine("캐릭터의 공격력을 입력하세요 : ");
            att = int.Parse(Console.ReadLine());

            //기본공격력
            baseAtt = BaseAttack();

            AttackFunction(att + baseAtt);*/

            /*string[] fruits = { "사과", "바나나", "체리" };

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/

        }
    }
}
