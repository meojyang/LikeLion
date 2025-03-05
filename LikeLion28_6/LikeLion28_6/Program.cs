using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion28_6
{
    public class Player
    {
        protected string Name; //외부에서 쓸수없는 protected
        //즉 상속 관계에서만 쓴다

        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("부모 클래스 생성자입니다.");
        }
        //player의 생성자에 출력을 하게 해놓고

        public void ShowName()
        {
            Console.WriteLine(Name);
        }

                                    
    }

    public class Wizard : Player
    {

        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("마법사 생성자입니다.");
        }
        //이 player를 상속받은 자식클래스 wizard가 있을경우
        //wizard의 생성자로 객체를 생성하면
        //부모클래스의 생성자가 먼저 돌아서 부모클래스 생성자입니다도 출력이 된다.
    }

    class Program
    {
        static void Main(string[] args)
        {

            Player p = new Player();
            p.ShowName();

            Wizard w = new Wizard();
            w.ShowName();

        }
    }
}
