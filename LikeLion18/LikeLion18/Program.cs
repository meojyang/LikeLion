using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion18
{
    struct Point
    {
        public int x;
        public int y;
    }

    struct Student
    {
        public string sName;
        public int iKor;
        public int iEng;
        public int iMath;

        public void Print()
        {
            Console.WriteLine($"{sName}\t{iKor}\t{iEng}\t{iMath}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Point[] points = new Point[2];
            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;

            foreach(var point in points)
            {
                Console.WriteLine($"Point: {point.x}, {point.y}");
            }*/

            Student[] students = new Student[3];

           
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("학생 정보를 입력하세요.");
                
                Console.Write("이름 : ");
                students[i].sName = Console.ReadLine();
                Console.Write("국어 성적 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 성적 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 성적 : ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름\t국어\t영어\t수학");
            
            foreach(Student std in students) std.Print();

        }
    }
}
