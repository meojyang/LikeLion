using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion19
{
    class Program
    {
        static void Main(string[] args)
        {

            //내장형 구조체

            DateTime now = DateTime.Now;
            Console.WriteLine($"지금 날짜와 시간: {now}");

            TimeSpan duration = new TimeSpan(1, 30, 0); //1시간 30분을 표시
            Console.WriteLine($"Duration: {duration}");
        }
    }
}
