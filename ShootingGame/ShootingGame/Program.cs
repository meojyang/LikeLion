using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{

    
    //발사될 미사일부터 만들자
    public class BULLET
    {
        public int bulletX; //미사일의 x좌표
        public int bulletY; //미사일의 y좌표
        public bool fire; //미사일이 발사돼서 날아다니는지 체크할 불값
    }

    //플레이어 비행기 클래스

    public class Player
    {

        const int UPKEY = 72;
        const int DOWNKEY = 80;
        const int LEFTKEY = 75;
        const int RIGHTKEY = 77;
        const int SPACEBAR = 32;

        [DllImport("msvcrt.dll")] //그냥 갖다쓰는 코드
        static extern int _getch(); //키 입력 반응을 더 빠르게 하기 위한 C언어의 로우 레벨 함수

        public int playerX; //플레이어의 x좌표
        public int playerY; //플레이어의 Y좌표
        public BULLET[] playerBullet = new BULLET[20]; //미사일을 갖고있으니
        public BULLET[] playerBullet2 = new BULLET[20]; //미사일을 갖고있으니
        public BULLET[] playerBullet3 = new BULLET[20]; //미사일을 갖고있으니

        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;
        

        public Player()
        {
            //플레이어의 위치 좌표 초기화
            playerX = 0;
            playerY = 12;

            //미사일도 배열에 객체를 만들어서 넣어준다
            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].bulletX = 0;
                playerBullet[i].bulletY = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].bulletX = 0;
                playerBullet2[i].bulletY = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].bulletX = 0;
                playerBullet3[i].bulletY = 0;
                playerBullet3[i].fire = false;
            }
        }

        public void GameMain()
        {
            
            //키를 입력받는 부분
            KeyControl();
            //플레이어를 그려준다
            PlayerDraw();

            UIscore();

            if (item.ItemLife) //아이템이 생성됐으면
            {
                item.ItemMove(); //움직이고
                item.ItemDraw(); //그리고
                CrashItem(); //충돌체크까지
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //문자열 배열로 플레이어 그리기


            for(int i = 0; i <player.Length; i++)
            {
                //콘솔좌표를 이용해 플레이어 위치를 설정
                Console.SetCursorPosition(playerX, playerY+i);
                //문자열배열 출력
                Console.WriteLine(player[i]);

            }
        }

        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)
            {
                pressKey = _getch(); //아스키코드표에서 왼쪽 오른쪽
                

                switch (pressKey)
                {
                    case UPKEY: //위족 방향 화살표
                    {
                            playerY--;
                            if (playerY < 1)
                                playerY = 1; //화면상에서 좌표가 1보다 작으면 1로 고정을 해줄거
                            break;
                    }
                    case LEFTKEY: //왼쪽 화살표키
                     {
                            playerX--;
                            if (playerX < 0)
                                playerX = 1;
                            break;
                     }
                    case RIGHTKEY: //오른쪽 화살표키
                     {
                            playerX++;
                            if (playerX > 75)
                                playerX = 75;
                            break;
                     }
                    case DOWNKEY: //아래 화살표키
                     {
                            playerY++;
                            if (playerY > 21)
                                playerY = 21;
                            break;
                     }
                    case SPACEBAR: //스페이스바
                     {
                            for(int i = 0; i < 20; i++)
                            {
                                if (playerBullet[i].fire == false)
                                {
                                    playerBullet[i].fire = true;
                                    //플레이어 앞에서 미사일이 나가야 하기 때문에
                                    //좌표를 플레이어 앞쪽으로 설정해줘야함
                                    playerBullet[i].bulletX = playerX + 5;
                                    playerBullet[i].bulletY = playerY + 1;
                                    
                                    //한발씩 쏠거니까 한발 쏘고나면 브레이크
                                    break;
                                }
                            }

                            for (int i = 0; i < 20; i++) //미사일 2 발사
                            {
                                if (playerBullet2[i].fire == false)
                                {
                                    playerBullet2[i].fire = true;
                                    //플레이어 앞에서 미사일이 나가야 하기 때문에
                                    //좌표를 플레이어 앞쪽으로 설정해줘야함
                                    playerBullet2[i].bulletX = playerX + 5;
                                    playerBullet2[i].bulletY = playerY;

                                    //한발씩 쏠거니까 한발 쏘고나면 브레이크
                                    break;
                                }
                            }

                            for (int i = 0; i < 20; i++) //미사일 3 발사
                            {
                                if (playerBullet3[i].fire == false)
                                {
                                    playerBullet3[i].fire = true;
                                    //플레이어 앞에서 미사일이 나가야 하기 때문에
                                    //좌표를 플레이어 앞쪽으로 설정해줘야함
                                    playerBullet3[i].bulletX = playerX + 5;
                                    playerBullet3[i].bulletY = playerY + 2;

                                    //한발씩 쏠거니까 한발 쏘고나면 브레이크
                                    break;
                                }
                            }
                            break;
                     }

                 
                }
            }
        }

        public void BulletDraw()
        {
            string bullet = "->";

            //미사일은 20개니까
            for(int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //중간위치 보정을 위해 X좌표는 -1을 해준다
                    Console.SetCursorPosition(playerBullet[i].bulletX - 1, playerBullet[i].bulletY);
                    Console.Write(bullet);

                    playerBullet[i].bulletX++; //한번 그릴때마다 오른쪽으로 미사일이 날아가야함

                    if (playerBullet[i].bulletX > 78)
                    {
                        playerBullet[i].fire = false; //화면밖을 넘어가면 미사일을 다시 준비상태로 변경
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = "->";

            //미사일은 20개니까
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //중간위치 보정을 위해 X좌표는 -1을 해준다
                    Console.SetCursorPosition(playerBullet2[i].bulletX - 1, playerBullet2[i].bulletY);
                    Console.Write(bullet);

                    playerBullet2[i].bulletX++; //한번 그릴때마다 오른쪽으로 미사일이 날아가야함

                    if (playerBullet2[i].bulletX > 78)
                    {
                        playerBullet2[i].fire = false; //화면밖을 넘어가면 미사일을 다시 준비상태로 변경
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->";

            //미사일은 20개니까
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //중간위치 보정을 위해 X좌표는 -1을 해준다
                    Console.SetCursorPosition(playerBullet3[i].bulletX - 1, playerBullet3[i].bulletY);
                    Console.Write(bullet);

                    playerBullet3[i].bulletX++; //한번 그릴때마다 오른쪽으로 미사일이 날아가야함

                    if (playerBullet3[i].bulletX > 78)
                    {
                        playerBullet3[i].fire = false; //화면밖을 넘어가면 미사일을 다시 준비상태로 변경
                    }
                }
            }
        }

        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20개와 전부 비교를 해야함;;
            for(int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같고 x값도 같아야 총알과 적이 충돌하겠지
                    if (playerBullet[i].bulletY == enemy.enemyY)
                    {
                        if (playerBullet[i].bulletX >= (enemy.enemyX - 1) &&
                            playerBullet[i].bulletX <= (enemy.enemyX+1))
                        {

                            item.ItemLife = true;
                            item.ItemX = enemy.enemyX;
                            item.ItemY = enemy.enemyY;
                            //충돌할경우
                            //다시 적을 만들어줌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; //미사일도 다시 준비상태로바꿔줌

                            //미사일이 적과 충돌했으니 득점
                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같고 x값도 같아야 총알과 적이 충돌하겠지
                    if (playerBullet2[i].bulletY == enemy.enemyY)
                    {
                        if (playerBullet2[i].bulletX >= (enemy.enemyX - 1) &&
                            playerBullet2[i].bulletX <= (enemy.enemyX + 1))
                        {
                            
                            item.ItemX = enemy.enemyX;
                            item.ItemY = enemy.enemyY;
                            

                            //충돌할경우
                            //다시 적을 만들어줌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일도 다시 준비상태로바꿔줌

                            //미사일이 적과 충돌했으니 득점
                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같고 x값도 같아야 총알과 적이 충돌하겠지
                    if (playerBullet3[i].bulletY == enemy.enemyY)
                    {
                        if (playerBullet3[i].bulletX >= (enemy.enemyX - 1) &&
                            playerBullet3[i].bulletX <= (enemy.enemyX + 1))
                        {
                            
                            //충돌할경우
                            //다시 적을 만들어줌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; //미사일도 다시 준비상태로바꿔줌

                            //미사일이 적과 충돌했으니 득점
                            Score += 100;
                        }
                    }
                }
            }

        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사

        public void CrashItem()
        {
            if(playerY+1 == item.ItemY)
            {
                if(playerX >= item.ItemX -2 && playerX <= item.ItemX + 2)
                {
                    item.ItemLife = false; //먹었으니 아이템 없애주고

                    if(itemCount < 3) //3개 보다 적으면
                        itemCount++; //아이템 갯수 먹은거 한개 늘려주고

                    for(int i = 0; i <20; i++)
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].bulletX = 0;
                        playerBullet[i].bulletY = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].bulletX = 0;
                        playerBullet2[i].bulletY = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].bulletX = 0;
                        playerBullet3[i].bulletY = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

    }

    public class Enemy // 적 클래스
    {
        public int enemyX; //적의 X좌표
        public int enemyY;  //적의  Y좌표

        public Enemy()
        {
            //적의 위치좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            String enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--; //그냥 단순하게 왼쪽으로 움직여

            if(enemyX < 2) //화면 왼쪽 끝까지 가게 되면 새 적이 나와야하니까
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22); //2~21 사이에서만 나오게
            }
        }


    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int ItemX = 0;
        public int ItemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(ItemX, ItemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
           /* if(ItemX <= 1 || ItemY <= 1)
            {
                ItemLife = false;
            }*/
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false;

            //플레이어 입장~!
            Player player = new Player();
            //적도 입장~!
            Enemy enemy = new Enemy();

            //유니티처럼 프레임의 속도를 잡아줄거다
            int dwTime = Environment.TickCount; // 1/1000초를 계산한 값이 들어가는 변수

            while (true)
            {
                //0.05초를 지연시킬거다
                if (dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Console.Clear();
                    //0.05초마다 그려주고 지워줄거다

                    //플레이어
                    player.GameMain();

                    if(player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if(player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    enemy.EnemyMove(); // 적을 이동시키고
                    enemy.EnemyDraw(); // 적을 그린다

                    //총알과 적이 충돌하는것을 처리하는 부분
                    player.ClashEnemyAndBullet(enemy);
                }


            }


        }
    }
}
