using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {

        const int MAX_ITEMS = 10;
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];

        static void AddItem(string name, int count)
        {
            for(int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    itemCounts[i] += count;
                    return;
                }
            }

            for(int i = 0; i <MAX_ITEMS; i++)
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

        static void RemoveItem(string name, int count)
        {
            for(int i = 0; i<MAX_ITEMS; i++)
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

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리: ");
            bool isEmpty = true;

            for(int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]}\t(x {itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if (isEmpty) Console.WriteLine("인벤토리가 비어있습니다.");
        }

        static void Main(string[] args)
        {
            AddItem("포션", 5);
            AddItem("대검", 1);
            AddItem("포션", 3);

            ShowInventory();

            Console.WriteLine("포션 2개 사용");
            RemoveItem("포션", 2);
            ShowInventory();

            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);
            ShowInventory();

            Console.WriteLine("포션 6개 사용");
            RemoveItem("포션", 6);
            ShowInventory();
        }
    }
}
