using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion22
{
    /*class Person
    {
        private string name;

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }
    }*/

   /* class Person
    {
        private string name; //내부변수

        public string Name //프로퍼티
        {
            get { return name; }
            set { name = value; }

            //C#은 get, set을 좀더 간단하게 만들수가 있다.
        }
    }*/

    //여기서 끝이 아니다?? 프로퍼티가 자동 구현도 된다??

    class Person
    {
        private int count = 100;

        public string Name { get; set; }

        public int Count
        {
            get { return count; } //읽기만 가능
        }

        public float Balance { get; private set; }

        public void AddBal() { Balance += 100; }
    }

    class Marine
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Person p = new Person();
            //private한 person의 name 변수에 함수를 이용해 접근하는 법
            p.Name = "홍길동";
            p.AddBal();

            Console.WriteLine("이름: " + p.Name +" Count: " + p.Count + " Balance: " + p.Balance);*/

            Marine m1 = new Marine();
            
            m1.Mineral = 50;
            Console.WriteLine("이름: " + m1.Name + " 미네랄: " + m1.Mineral);
        }
    }
}
