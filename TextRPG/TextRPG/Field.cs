using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Field
    {
        //플레이어가 필드에 있어야하니까
        Player m_pPlayer = null;

        //몬스터도 있어야할거아냐
        Monster monster = null;

        //플레이어는 maingame에서 생성했는데 그걸 받아와야함
        //플레이어는 필드에서 전투하면 데미지를 입고 Hp가 깎일것임
        //maingame에서 생성한 플레이어를 가져오기 위해 ref를 써보자

        public void SetPlayer(ref Player player) { m_pPlayer = player; }

        public void Progress()
        {
            //사냥터에서 입력받을 키
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render(); //사냥터에 들어온 플레이어 그리기
                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if(iInput <= 3)
                {
                    //몬스터를 만든다
                    //1번이면 초보몹
                    //2번이면 중간몹
                    //3번이면 고급몹
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }

            }

        }

        private void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("===================");
            Console.WriteLine("맵을 선택하세요.");
        }


        public void Create(string __strName, int __iHp, int __iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = __strName;
            tMonster.iHp = __iHp;
            tMonster.iAttack = __iAttack;

            pMonster.SetMonster(tMonster);
        }


        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //팩토리 메소드 패턴
                    Create("초급 몬스터", 30, 3, out monster);
                    break;
                case 2:
                    //팩토리 메소드 패턴
                    Create("중급 몬스터", 60, 6, out monster);
                    break;
                case 3:
                    //팩토리 메소드 패턴
                    Create("고급 몬스터", 90, 9, out monster);
                    break;

            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render(); //싸울 플레이어 출력
                monster.Render();

                Console.WriteLine("1. 공격 2. 도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    //플레이어가 데미지를 주고 몬스터도 데미지를 줘야함
                    m_pPlayer.SetDamage(monster.GetMonster().iAttack);
                    monster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if(m_pPlayer.GetInfo().iHp <= 0) //죽으면
                    {
                        m_pPlayer.SetHp(100); //부활시켜줌
                        break;
                    }
                }
                if(iInput == 2 || monster.GetMonster().iHp <= 0)
                {
                    monster = null;
                    break;
                }
            }
        }

        public Field() { }
        ~Field() { }


    }
}
