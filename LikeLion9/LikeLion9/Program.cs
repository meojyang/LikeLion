using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int score;
            Console.Write("점수를 입력해주세요: ");
            score = int.Parse(Console.ReadLine());
                        

            if(score >= 90)
            {
                Console.WriteLine("A학점");
                
            }
            else if(score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }
*/

            //가진 소지금 입력
            //0~100 무한의 대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4 
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6

            int money = 0;
            int addAttack = 0;
            string weaponName = default;
            
            Console.WriteLine("0~100 무한의대검 +1");
            Console.WriteLine("101~200 카타나 +2");
            Console.WriteLine("201~300 진은검 +3");
            Console.WriteLine("301~400 집판검 +4");
            Console.WriteLine("401~500 엑스칼리버 +5");
            Console.WriteLine("501~600 유령검 +6");
            Console.WriteLine("601~ 전설의 검 +7");
            Console.WriteLine("===================");
            Console.Write("\n소지금을 입력하세요: ");

            money = int.Parse(Console.ReadLine());


            if (money <= 100)
            {
                addAttack = 1;
                weaponName = "무한의대검";
            }
            else if (money <= 200)
            {
                addAttack = 2;
                weaponName = "카타나";
            }
            else if (money <= 300)
            {
                addAttack = 3;
                weaponName = "진은검";
            }
            else if (money <= 400)
            {
                addAttack = 4;
                weaponName = "집판검";
            }
            else if (money <= 500)
            {
                addAttack = 5;
                weaponName = "엑스칼리버";
            }
            else if (money <= 600)
            {
                addAttack = 6;
                weaponName = "유령검";
            }
            else if (money > 600)
            {
                addAttack = 7;
                weaponName = "전설의검";
            }
            Console.WriteLine("\n===================");
            Console.WriteLine("캐릭터 이름: 멋사검존");
            Console.WriteLine("무기: " + weaponName);
            Console.WriteLine("공격력: 100 + " + addAttack);
        }
    }
}
