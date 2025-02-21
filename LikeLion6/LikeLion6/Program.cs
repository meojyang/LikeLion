using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LikeLion6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //사용자의 입력을 문자열로 받기
            Console.Write("이름을 입력하세요: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"안녕하세요, {userName}님!");
            //$(달러)기호는 중괄호 안에 변수를 쓸 수 있게 만들어준다.
            */

            /*
            Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine(); //사용자로부터 입력을 받는다
            int age = int.Parse(input); //입력받은 문자열을 정수로 변환
            Thread.Sleep(1000); //1초동안 기다렸다가
            Console.Clear(); // 콘솔을 지우고

            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); //문자열 출력
            Console.WriteLine("올해는 " + age + "살이군요!"); //문자열 출력
            Console.WriteLine("내년에는 {0}살이 되겠군요!", age); //{0}는 %d 같은거 변수가 이 위치로 들어간다는 표시
            */

            float ruinSkillDamage;
            float cardGuage;
            float ultDamage;
            int maxMp;
            int battleMpRecover;
            int normalMpRecover;
            float speed;
            float vehicleSpeed;
            float movingSpeed;
            float reduceCooldown;

            Console.Write("루인 스킬 피해: ");
            ruinSkillDamage = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량: ");
            cardGuage = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해: ");
            ultDamage = float.Parse(Console.ReadLine());
            Console.Write("최대 마나: ");
            maxMp = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량: ");
            battleMpRecover = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량: ");
            normalMpRecover = int.Parse(Console.ReadLine());
            Console.Write("이동 속도: ");
            speed = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도: ");
            vehicleSpeed = float.Parse(Console.ReadLine());
            Console.Write("운반 속도: ");
            movingSpeed = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소: ");
            reduceCooldown = float.Parse(Console.ReadLine());



            Console.WriteLine($"\n루인 스킬 피해: {ruinSkillDamage}%");
            Console.WriteLine($"카드 게이지 회복량: {cardGuage}%");
            Console.WriteLine($"각성기 피해: {ultDamage}%");
            Console.WriteLine($"최대 마나: {maxMp}");
            Console.WriteLine($"전투 중 마나 회복량: {battleMpRecover}");
            Console.WriteLine($"비전투 중 마나 회복량: {normalMpRecover}");
            Console.WriteLine($"이동 속도: {speed}%");
            Console.WriteLine($"탈 것 속도: {vehicleSpeed:F1}%");
            Console.WriteLine($"운반 속도: {movingSpeed:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {reduceCooldown}%");
        }
    }
}
