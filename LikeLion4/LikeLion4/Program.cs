using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ctrl + / 하면 드래그 한곳 주석 하는 단축키
            // Ctrl + shift + / 하면 드래그 한곳 전체 주석하는 단축키 /**/ 이거

            /*string greeting; // 문자열 변수를 선언
            greeting = "Hello, World!"; // 변수에 헬로월드 값을 저장

            Console.WriteLine(greeting); //greeting에 저장된 값을 출력
*/

            /*// 변수 선언과 초기화를 동시에

            int score = 100; //score라는 int형 변수를 선언하면서 100이라는 값으로 초기화함
            double temperature = 36.5;
            string city = "seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city);
*/

            /*// 같은 데이터 타입의 변수를 쉼표로 구분해서 동시에 선언
            int x = 10, y = 20, z = 30;


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            /*const double Pi = 3.14159;
            const int MaxScore = 100;

            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("MaxScore  : " + MaxScore);*/

            int att = 16755;
            int maxHP = 78103;
            int cri = 36;
            int major = 1017;
            int supp = 41;
            int speed = 611;
            int endure = 22;
            int exp = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("최대 생명력 : " + maxHP + '\n');
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명 : " + cri);
            Console.WriteLine("특화 : " + major);
            Console.WriteLine("제압: " + supp);
            Console.WriteLine("신속 : " + speed);
            Console.WriteLine("인내 : " + endure);
            Console.WriteLine("숙련 : " + exp);
        }
    }
}
