using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion30
{
    class MyResource
    {
        ~MyResource() //소멸자
        {
            Console.WriteLine("삭제될때 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyResource r = new MyResource();
            //GC에 의해 나중에 소멸자 호출
        }
    }
}
