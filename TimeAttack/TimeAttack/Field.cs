using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TimeAttack
{
    public class Field
    {
        public Player F_player = null;
        public Monster F_monster = null;

        //필드에는 기존에 있던 플레이어 캐릭터를 가지고 와야함
        public void SetPlayer(ref Player player)
        {
            F_player = player;
        }

        public void DrawMap()
        {            
            Console.WriteLine("1. 초보사냥터");
            Console.WriteLine("2. 중급사냥터");
            Console.WriteLine("3. 고급사냥터");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=======================");
            Console.WriteLine("사냥터를 골라주세요.");
        }


        public void Create(string mName, int mHp, int mAttack, out Monster m)
        {
            m = new Monster();
            INFO mInfo = new INFO();

            mInfo.Name = mName;
            mInfo.Hp = mHp;
            mInfo.Attack = mAttack;

            m.SetMonster(mInfo);
        }
        
        public void CreateMonster(int num)
        {
            switch (num)
            {
                case 1:
                    Create("초급몬스터", 30, 3, out F_monster);
                    break;
                case 2:
                    Create("중급몬스터", 60, 6, out F_monster);
                    break;
                case 3:
                    Create("고급몬스터", 90, 9, out F_monster);
                    break;
            }
        }

        public void Progress()
        {
            int input = 0; //사냥터에서 입력받을 키

            while (true)
            {
                Console.Clear(); //싸@악 지워주고

                F_player.Render(); //플레이어 정보 그려주고
                DrawMap(); //맵부터 그리고
                input = int.Parse(Console.ReadLine()); //맵을 선택할거임

                if (input == 4) break; //4번은 이전으로 돌아가기 니까 break;

                if (input <= 3)
                {
                    CreateMonster(input); //그러면 맵에 맞는 몬스터를 생성해준다
                    Fight(); //그리고 몬스터와 싸울거임
                }
            }

        }

        public void Fight()
        {
            int input = 0;
            //누구하나 죽을때까지 반복해야하니까
            while (true)
            {
                Console.Clear(); //싸@악 지워주고

                F_player.Render(); //플레이어 정보 그려주고
                F_monster.Render(); //몬스터 정보도 그려준다

                Console.WriteLine("1. 공격  2. 도망");
                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    F_player.GetDamage(F_monster.GetInfo().Attack);
                    F_monster.GetDamage(F_player.GetInfo().Attack);
                    if (F_player.GetInfo().Hp <= 0)
                    {
                        F_player.SetHp(100);
                        break;
                    }
                }
                if (input == 2 || F_monster.GetInfo().Hp <= 0)
                {
                    F_monster = null;
                    break;
                }


            }
        }
        public Field() { }
        ~Field() { }
        
    }
}
