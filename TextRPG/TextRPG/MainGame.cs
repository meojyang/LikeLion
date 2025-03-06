using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MainGame
    {
        public Player m_pPlayer = null;
        public Field m_pField = null;

        //초기화 해주는 함수
        public void Initialize()
        {
            //플레이어 생성 및 직업 선택
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
        }

        //게임의 전체적인 진행 과정 관리
        public void progress()
        {
            int Iinput = 0;
            while (true)
            {
                Console.Clear(); //게임 그려야하니까 딱 깔@꼼하게 지워주고
                m_pPlayer.Render(); //플레이어 정보들 쌈@뽕하게 그려주고
                Console.Write("1.사냥터 2.종료 : ");
                Iinput = int.Parse(Console.ReadLine()); //숫자를 입력받아서

                if(Iinput == 2) break; //2면 종료
                
                if(Iinput == 1)
                {
                    //사냥터 구현
                    if(m_pField == null) //필드 객체가 없으면
                    {
                        m_pField = new Field(); //새로 생성하고
                        m_pField.SetPlayer(ref m_pPlayer); //플레이어 세팅해줌 ref로
                    }
                    m_pField.Progress(); //필드에서의 진행과정 실행

                }
            }
        }

        public MainGame() { }
        ~MainGame() { }
    }
}


//오늘 과제
//상속으로 만들어보기
//한번 보면서 다시 만들어보기