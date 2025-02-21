using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            //리터럴: 코드에서 고정된 값을 의미한다!
            int number = 10; //10은 정수형 리터럴
            double pi = 3.14; //3.14는 실수형 리터럴
            char letter = 'A'; //A는 문자 리터럴
            string name = "Alice"; //Alice는 문자열 리터럴

            Console.WriteLine(number); // number를 출력한다, 10이 출력될 것
            Console.WriteLine(pi); // pi를 출력한다. 3.14가 출력될 것
            Console.WriteLine(letter); // letter를 출력한다. A가 출력될 것
            Console.WriteLine(name); // name을 출력한다. Alice가 출력될 것


            */

            int hp = 100;
            double att = 56.7;
            string charname = "name";
            char rank = 'S';


            Console.WriteLine("캐릭터");
            Console.WriteLine("캐릭터 이름 : " + charname);
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("att : " + att);
            Console.WriteLine("등급 : " + rank);



        }
    }
}
