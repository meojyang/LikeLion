using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion16
{
    class Program
    {


        static void Main(string[] args)
        {
            /*//Math클래스 사용
            Console.WriteLine($"Pi: {Math.PI:F2}");
            //수학적 계산
            Console.WriteLine($"Sqaure root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3): {Math.Pow(2,3)}");
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");*/


            /*//숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine(today);
            Console.WriteLine((int)today);


            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);*/

            ChooseWeapon(WeaponType.Bow);
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword) Console.WriteLine("검을 선택했습니다.");
            else if (weapon == WeaponType.Bow) Console.WriteLine("활을 선택했습니다.");
            else if (weapon == WeaponType.Staff) Console.WriteLine("지팡이를 선택했습니다.");
        }

        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
