using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion21
{   
    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.supply = 4;
            Game.ShowInfo();

            Marine m2 = new Marine("레이너", 150);
            
            SCV s2 = new SCV("일꾼", 50);

            Barracks barrack = new Barracks("병영",150);
            barrack.ShowInfo();

            Mineral[] minerals = new Mineral[7];

            for(int i = 0; i < minerals.Length; i++)
            {
                minerals[i] = new Mineral("Mineral Fields");
                minerals[i].ShowInfo();
                
            }
        }
    }

    //Game 클래스를 만들어보자

    //클래스에서도 static 키워드를 사용해서 바로 접근 할 수 있다.
    
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int supply;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral}  가스 {gas}  인구수 {supply}");
        }
    }

    class Mineral
    {
        public int Minerals = 1500;
        public string Name;
        

        public Mineral(string name)
        {            
            Name = name;            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 남은 미네랄: {Minerals}");
        }

    }

    class Barracks
    {
        public string name;
        public int mineral;

        public Barracks()
        {
            Console.WriteLine("배럭 1채 건설 완료");
        }

        public Barracks(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"name: {name}, mineral: {mineral}");
        }

    }


    //마린 클래스 만들기
    //이름, 미네랄
    //기본 생성자, 인자 있는 생성자


    class Marine
    {
        public string name;
        public int mineral;

        public Marine()
        {
            Console.WriteLine("Who wanna piece of meat, boy?");
        }

        public Marine(string str, int cost)
        {
            name = str;
            mineral = cost;
            Console.WriteLine($"{name} 1기 생성, {mineral} 소모.");
        }
    }

    class SCV
    {
        public string name;
        public int mineral;

        public SCV()
        {
            name = "scv";
            mineral = 50;
            Console.WriteLine("SCV good to go sir!");
        }

        public SCV(string str, int cost)
        {
            name = str;
            mineral = cost;
            Console.WriteLine($"{name}, 야근하러 {mineral}을 소모해 준비 완료!");
        }
    }
}
