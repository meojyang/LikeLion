using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LikeLion23
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

    }

    public class NewPlayer : Player
    {
        public int Strength { get; set; }
    }

    /*public class Enemy: Iattackable, Imovable
    {
        public void Attack() { }
        public void Move() { }
    }*/ //인터페이스처럼 쓰는 클래스

    //추상 클래스

    public abstract class Animal
    {
        public abstract void MakeSound();
    }




    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.WriteLine("종료");
                        Environment.Exit(0);*//*

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: { path}");

            Environment.Exit(0);*/

            /*Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine(randomNumber);*/

            /*Stopwatch stopwatch = Stopwatch.StartNew();

            for(int i = 0; i < 100000; i++)
            {

            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);*/


            /*string input = "1234567890";
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"Is valid phone number: {isMatch}");*/



        }
    }
}
