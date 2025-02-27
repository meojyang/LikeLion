using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        //인벤토리
        //가방을 이루는 정보 요소들은?
        struct Inven
        {
            const int MAX_ITEMS = 10; // 가방 칸의 갯수

            public string[] itemNames; // 가방 안에 있는 아이템의 이름들
            public int[] itemCounts; // 그 아이템의 갯수

            public Inven(bool init)
            {
                itemNames = new string[MAX_ITEMS];
                itemCounts = new int[MAX_ITEMS];
            }

            public void AddItem(string name, int count) //가방 안에 아이템을 추가하기 위해선?
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name)
                    {
                        itemCounts[i] += count;
                        return;
                    }
                }

                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == null)
                    {
                        itemNames[i] = name;
                        itemCounts[i] = count;
                        return;
                    }
                }
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }

            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name)
                    {
                        if (itemCounts[i] >= count)
                        {
                            itemCounts[i] -= count;
                            if (itemCounts[i] == 0)
                            {
                                itemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템이 부족합니다.");
                            return;
                        }
                    }
                }
                Console.WriteLine("아이템이 존재하지 않습니다.");
            }

            public void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리: ");
                bool isEmpty = true;

                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] != null)
                    {
                        Console.WriteLine($"{itemNames[i]}\t(x {itemCounts[i]})");
                        isEmpty = false;
                    }
                }
                if (isEmpty) Console.WriteLine("인벤토리가 비어있습니다.");
            }
        }

        static void Main(string[] args)
        {
            Inven inv = new Inven(true);

            inv.AddItem("포션", 2);
            inv.ShowInventory();

            Console.WriteLine("포션 2개 사용.");
            inv.RemoveItem("포션", 2);
            inv.ShowInventory();

            Console.WriteLine("폭탄 2개 구매.");
            inv.AddItem("폭탄", 2);
            inv.ShowInventory();

            
           
        }
    }
}
