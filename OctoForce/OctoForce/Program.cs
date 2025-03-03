using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OctoForce
{
    class Octopus
    {
        public int level = 1; //문어의 현재 레벨
        public int count = 0; //문어 키우기 시도한 횟수
        public int percent = 90;
        public bool run = false;
        public bool isVictory = false;
        
        public void Feeding()
        {
            count++;
        }


        public void DrawOctopus()
        {
            if ((count+1) % 2 == 0)
            {
                Console.SetCursorPosition(5, 5);
                Console.Write(" (..)");
                Console.SetCursorPosition(5, 6);
                Console.Write("((()))");
            }
            else if(count % 4 == 0)
            {
                Console.SetCursorPosition(5, 5);
                Console.Write("  (..)");
                Console.SetCursorPosition(5, 6);
                Console.Write("((()))");
            }
            else
            {
                Console.SetCursorPosition(5, 5);
                Console.Write("(..)");
                Console.SetCursorPosition(5, 6);
                Console.Write("((()))");
            }

        }


        public void TryLevelUp()
        {
            Random rand = new Random();
            int n = rand.Next(0, 101);

            if (level == 1)
            {
                if(n <= percent)
                {
                    Console.SetCursorPosition(26, 20);
                    Console.Write("문어가 성장에 성공했습니다!");
                    Thread.Sleep(500);
                    level++;
                    percent -= 15;
                }
                else
                {
                    Console.SetCursorPosition(26, 20);
                    Console.Write("문어가 성장에 실패했습니다..");
                    Thread.Sleep(500);
                }
            }
            else if(level >= 2 && level <7)
            {
                if (n <= percent)
                {
                    Console.SetCursorPosition(26, 20);
                    Console.Write("문어가 성장에 성공했습니다!");
                    Thread.Sleep(500);
                    level++;
                    percent -= 15;
                }
                else if(n == 1 || n == 100)
                {
                    Console.SetCursorPosition(26, 20);
                    Console.Write("문어가 급성장했습니다!!");
                    Thread.Sleep(1000);
                    level += 2;
                    percent -= 30;
                }
                else
                {
                    Console.SetCursorPosition(26, 20);
                    Console.Write("문어가 성장에 실패했습니다..");
                    Thread.Sleep(500);
                    level--;
                    percent += 15;
                }
            }
            else
            {
                Console.SetCursorPosition(26, 20);
                Console.WriteLine("문어가 성장을 마쳤습니다!!");
                Console.SetCursorPosition(26, 21);
                Console.Write("승리를 축하합니다!");
                Thread.Sleep(500); 
                isVictory = true;
            }

        }

        public bool GameOver()
        {
            if (count > 100)
            {              
                Console.SetCursorPosition(25, 17);
                Console.WriteLine("문어가 배가 터져 죽었습니다...");
                return true;
            }            
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false;

            Console.SetCursorPosition(28, 5);
            Console.Write("┏━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(28, 6);
            Console.Write("┃                ┃");
            Console.SetCursorPosition(29, 6);
            Console.Write(" 황금문어 키우기");
            Console.SetCursorPosition(28, 7);
            Console.Write("┗━━━━━━━━━━━━━━━━┛"); // 타이틀 그리기

            Console.SetCursorPosition(34, 9);
            Console.Write("(..)");
            Console.SetCursorPosition(33, 10);
            Console.Write("((()))");

            Console.SetCursorPosition(24, 13);
            Console.Write(">> Press Enter to Start <<");
            Console.ReadLine();

            

            Octopus oct = new Octopus();

            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(61, 0);
                Console.Write("┏━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(61, 1);
                Console.Write("┃               ┃");
                Console.SetCursorPosition(63, 1);
                Console.Write("[먹이 준 횟수]");
                Console.SetCursorPosition(61, 2);

                if (oct.count < 10)
                    Console.Write("┃    " + oct.count + " / 100    ┃");                
                else if(oct.count >= 10 && oct.count < 100)
                    Console.Write("┃    " + oct.count + " / 100   ┃");
                else
                    Console.Write("┃    " + oct.count + " / 100  ┃");
                //숫자 자리수 늘어나면서 칸이 늘어나서 칸 조정용 if문

                Console.SetCursorPosition(61, 3);
                Console.Write("┗━━━━━━━━━━━━━━━┛"); //먹이준 횟수 그리기


                oct.DrawOctopus();


                Console.SetCursorPosition(28, 12);
                Console.Write("현재 레벨 : " + oct.level);
                Console.SetCursorPosition(28, 13);
                if(oct.level == 7)
                    Console.Write("다음 레벨 : MAX");
                else
                    Console.Write("다음 레벨 : " + (oct.level + 1));
                Console.SetCursorPosition(28, 15);
                Console.Write("성장 확률 : " + oct.percent + "%");

                Console.SetCursorPosition(28, 17);
                Console.Write("Enter키를 눌러 먹이주기");
                Console.ReadLine();
                oct.Feeding();  //먹이를 준다
                oct.TryLevelUp();
                

                if (oct.GameOver() == true) break; //게임오버 판정 뜨면 반복문 탈출
                if (oct.isVictory == true) break; //문어를 7레벨까지 키우면 승리

            }                    

        }
    }
}
