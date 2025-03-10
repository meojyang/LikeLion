﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Ball
    {
        BALLDATA m_tBall = new BALLDATA();

        //공의 방향을 배열로 정의

        int[,] g_WallCollision = new int[4, 6]//4는 벽 네개, 6개는 공의방향
        {
            {3, 2, -1, -1, -1, 4},  //위쪽 벽에 부딪혔을때 공의 방향에 따른 다음 방향을 정의해주는거임
            {-1, -1, -1, -1, 2, 1}, //왼쪽 벽에 부딪혔을때
            {-1, 5, 4, -1, -1, -1}, //오른쪽 벽에 부딪혔을때
            {-1,-1, 1, 0, 5, -1}, //아래쪽 벽에 부딪혔을때
        };
                

        //방향은 시계방향으로 정의해놨는데 벽은 시계방향이 아니라서 헷갈리네요

        //움직일 bar
        Bar m_pBar;
        
        public void SetBar(Bar bar) { m_pBar = bar; }
        //여기에 넣어놓고 필요하면 쓰겠다

        //block
        Block[] m_block = new Block[10]; //블럭 배열

        public void SetBlock(Block[] b) { m_block = b; }

        public void ScreenWall()
        {
            Program.gotoxy(0, 0); //Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public int Collision(int x,  int y)
        {
            
            if(y == 0) //위쪽 벽에 충돌하면
            {
                m_tBall.nDirect = g_WallCollision[0, m_tBall.nDirect];
                return 0; //공의 방향이 바뀌면 0을 리턴

            }
            if(x == 1) //왼쪽 벽에 충돌하면
            {
                m_tBall.nDirect = g_WallCollision[1, m_tBall.nDirect];
                return 0;
            }
            if (x == 77) //오른쪽벽에 충돌하면
            {
                m_tBall.nDirect = g_WallCollision[2, m_tBall.nDirect];
                return 0; //공의 방향이 바뀌면 0을 리턴

            }
            if (y == 23) //0번벽에 충돌하면
            {
                m_tBall.nDirect = g_WallCollision[3, m_tBall.nDirect];
                return 0; //공의 방향이 바뀌니 0 리턴
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
     y == (m_pBar.m_tBar.nY)) //바 위에 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 0; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 0; //방향이 바뀐다.
            }


            //블럭 위 아래 왼쪽 오른쪽 충돌 판정 if문
            for(int i = 0; i < 10; i++)
            {
                if (m_block[i] != null)
                {
                    if(x >= m_block[i].bd.nX && x <= m_block[i].bd.nX + 1 && y == m_block[i].bd.nY)
                    {
                        if (m_tBall.nDirect == 1)
                            m_tBall.nDirect = 2;
                        else if (m_tBall.nDirect == 2)
                            m_tBall.nDirect = 1;
                        else if (m_tBall.nDirect == 5)
                            m_tBall.nDirect = 4;
                        else if (m_tBall.nDirect == 4)
                            m_tBall.nDirect = 5;
                        m_block[i] = null;
                    }
                }
            }
            

            return 1;
        }



        public BALLDATA GetBall() { return m_tBall; }

        public void SetX(int x) { m_tBall.nX += x; }
        public void SetY(int y) { m_tBall.nY += y; }
        public void SetBall(BALLDATA tBall) { m_tBall = tBall; }
        public void SetReady(int Ready) { m_tBall.nReady = Ready; }

        public void Initialize()
        {
            m_tBall.nReady = 1; // 공움직임1 공안움직임0
            m_tBall.nDirect = 1;
            m_tBall.nX = 30;
            m_tBall.nY = 10;

            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if(m_tBall.nReady == 1) // 공이 움직이면
            {
                //공의 방향에 따른 스위치문
                switch (m_tBall.nDirect)
                {
                    case 0:// 위
                        if(Collision(m_tBall.nX, m_tBall.nY - 1) == 1)
                            m_tBall.nY--;
                        break;
                    case 1: //오른쪽 위
                        if (Collision(m_tBall.nX + 1, m_tBall.nY - 1) == 1)
                        {
                            m_tBall.nX++;
                            m_tBall.nY--;
                        }
                        break;
                    case 2: //오른쪽 아래
                        if (Collision(m_tBall.nX + 1, m_tBall.nY + 1) == 1)
                        {
                            m_tBall.nX++;
                            m_tBall.nY++;
                        }
                        break;
                    case 3: //아래
                        if (Collision(m_tBall.nX, m_tBall.nY + 1) == 1)
                            m_tBall.nY++;
                        break;
                    case 4: //왼쪽 아래
                        if (Collision(m_tBall.nX - 1, m_tBall.nY + 1) == 1)
                        {
                            m_tBall.nX--;
                            m_tBall.nY++;
                        }
                        break;
                    case 5: //왼쪽 위
                        if (Collision(m_tBall.nX - 1, m_tBall.nY - 1) == 1)
                        {
                            m_tBall.nX--;
                            m_tBall.nY--;
                        }
                        break;
                }
            }

        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(m_tBall.nX, m_tBall.nY);
            Console.Write("●");
        }

        public void Release() { }

    }
}
