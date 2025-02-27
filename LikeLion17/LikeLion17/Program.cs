using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion17
{

    //구조체
    struct Point
    {
        public int x;
        public int y;

        public void Print()
        {
            Console.WriteLine($"x좌표: {x}, y좌표: {y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Point p;
            p.x = 10;
            p.y = 20;

            p.Print();
        }
    }
}
