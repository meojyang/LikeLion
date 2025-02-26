using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] board = new int[25]; //보드판 배열 생성
            Random rand = new Random(); // 랜덤 객체 생성


            for(int i = 0; i < 25; i++) //보드판에 숫자 넣기
            {
                board[i] = i + 1;
            }

            for(int i =0; i<5; i++) //섞이기 전 빙고판 출력
            {
                for(int j = 0; j <5; j++)
                {
                    Console.Write(board[i * 5 + j].ToString("D2") + " "); //D2를 사용해서 0N으로이쁘게 정렬
                }
                Console.WriteLine();
            }


            for(int i = 0; i < 100; i++)
            {
                int a = rand.Next(0,25);
                int b = rand.Next(0,25);
                int t = 0;

                t = board[a]; //보드판의 a번째 요소를
                board[a] = board[b]; //보드판의 b번째 요소와 바꾼다
                board[b] = t;
            }

            Console.WriteLine("\n=======================\n");
            Console.Clear();

            int input = 0;
            int bingoCount = 0; //빙고 갯수
            int count = 0; //빙고가 되기전 별의 개수 체크용 카운트

            while (true)
            {
                
                //섞인 빙고판 출력
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (board[i * 5 + j] == 0) // 0일경우 체크
                        {
                            Console.Write("★ ");
                        }
                        else
                        {
                            Console.Write(board[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                    
                }
                Console.WriteLine("빙고 개수: " + bingoCount);
                Console.Write("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                bingoCount = 0; //여기서 빙고 갯수가 0으로 초기화 되더라도
                //밑에 체크하는 부분에서 걸려서 빙고 갯수는 계속 정상적으로 출력됨


                for(int i = 0; i < 25; i++) //보드판 배열 전체를 검사해서
                {
                    if (board[i] == input) //입력받은 숫자와 같으면
                    {
                        board[i] = 0; // 0으로 바꾸고 반복문 BREAK
                        break;
                    }
                }

                // 빙고를 체크하려면?
                // 가로 체크

                for (int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        if (board[i*5 + j] == 0)
                        {
                            count++;
                        }
                        if(count == 5)
                        {
                            bingoCount++;
                            
                        }
                        
                    }
                    count = 0;
                }

                // 세로 체크
                for(int i = 0; i <  5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        if (board[i+5*j] == 0)
                        {
                            count++;
                        }
                        if(count == 5)
                        {
                            bingoCount++;
                        }
                    }
                    count = 0;
                }

                // 왼쪽 대각선 체크
                for (int i = 0; i < 5; i++)
                {
                    if (board[i*4 +4] == 0)
                    {
                        count++;
                    }
                    
                    if(count == 5)
                    {
                        bingoCount++;
                    }
                    
                }
                count = 0;

                // 오른쪽 대각선 체크

                for (int i = 0; i < 5; i++)
                {
                    if (board[i * 6] == 0)
                    {
                        count++;
                    }

                    if (count == 5)
                    {
                        bingoCount++;
                    }
                    
                }
                count = 0;

                if (bingoCount >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }

            }*/

            //2차원 배열로 빙고판 만들기

            int[,] board = new int[5, 5]; // 5x5 빙고판 생성
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            Random rand = new Random();
            int bingoCount = 0; //빙고의 개수

            int[] numbers = new int[25];

            //빙고판 초기화
            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기
            for(int i = 0; i < 100; i++)
            {
                int a = rand.Next(25);
                int b = rand.Next(25);

                //C#의 튜플 문법을 활용해 두 변수를 swap
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            //2차원 배열의 빙고판 초기화
            int index = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //빙고가 5개 미만일때만 계속 돈다
            while(bingoCount < 5)
            {
                Console.Clear();

                Console.WriteLine("현재 빙고판");

                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($" {board[i, j] ,2}");                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수: {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25): ");

                int input = int.Parse(Console.ReadLine());
                
                bool found = false;
                
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == input) // 같은 숫자를 찾았다면
                        {
                            marked[i, j] = true;
                            found = true; //찾았다는 표시 해주고
                            break; //안쪽 반복문 탈출
                        }
                    }
                    if (found)
                        break; // i로 도는 for문을 불필요하게 돌지 않도록 break 추가
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로 체크
                for(int i = 0; i< 5; i++)
                {
                    bool rowBingo = true;
                    for(int j = 0; j<5; j++)
                    {
                        if (!marked[i, j]) rowBingo = false; // 체크판이 false이면 자연스레 빙고도 false
                    }
                    if (rowBingo) bingoCount++;
                }

                //세로 체크
                for(int j = 0; j<5; j++)
                {
                    bool colBingo = true;

                    for(int i = 0; i < 5; i++)
                    {
                        if (!marked[i, j]) colBingo = false;
                    }
                    if (colBingo) bingoCount++;
                }

                //대각선(11시에서 5시방향) 체크

                bool diag1Bingo = true;
                for(int i = 0; i< 5; i++)
                {
                    if (!marked[i, i]) diag1Bingo = false; //체크판에서 from11to5 대각선은 숫자가 같기 때문에 i[,i]

                }
                if(diag1Bingo) bingoCount++;

                //대각선(1시에서 7시방향) 체크

                bool diag2Bingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i,4 - i]) diag2Bingo = false; //from1to7 대각선은 04 13 22 31 40 이라서 [i, 4-i]

                }
                if (diag2Bingo) bingoCount++;


            }
            Console.WriteLine("빙고 5개 완성! 게임 클리어!");
        }
    }
}
