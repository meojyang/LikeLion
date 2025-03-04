using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion24
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int valueType = 10;
            object referenceType = valueType;
            valueType = 20;
            Console.WriteLine($"ValueType: {valueType}"); // 20
            Console.WriteLine($"ReferenceType: {referenceType}"); // 10*/

            /*int value = 42;
            object boxed = value; //박싱
            int unboxed = (int)boxed; //언박싱

            Console.WriteLine($"Boxed: {boxed}, unboxed: {unboxed}");*/
            //박싱과 언박싱


            /*//as 연산자를 사용해 안전하게 형 변환을 수행한다
            object obj = "Hello";

            string str = obj as string;

            Console.WriteLine(obj);
            Console.WriteLine(str);*/



            /*object obj = 42;
            var obj2 = 42;
            //둘중 박싱인것은? obj 입니당 object는 클래스고 var은 struct기때문

            if(obj is int number)
            {
                Console.WriteLine($"Number: {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }*/

            /*//문자열 다루기
            string greeting = "Hello";
            string name = "Alice";

            string message = greeting + "," + name;
            Console.WriteLine(message);

            Console.WriteLine($"Length of name: {name.Length}");
            Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            Console.WriteLine($"Substring: {name.Substring(1)}");*/

            /*string text = "C# is awesome!";
            //특정 문자열을 포함하고 있는지?
            Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");
            //특정 문자열로 시작하는지?
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            Console.WriteLine($"RePlace 'awesome' with 'great' : {text.Replace("awesome", "great")}");*/

            /*StringBuilder sb = new StringBuilder("Hello");
            sb.Append(", ");
            sb.Append("World!");
            Console.WriteLine(sb.ToString());*/

            /*//stringbuilder는 반복적으로 문자열을 수정할때 효율적이다

            int iterations = 10000;

            Stopwatch sw = Stopwatch.StartNew();

            string text = "";

            for(int i = 0; i<iterations; i++)
            {
                text += "a";
            }

            sw.Stop();
            Console.WriteLine($"String: {sw.ElapsedMilliseconds}");
            //6ms나오고

            sw.Restart();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i<iterations; i++)
            {
                sb.Append("a");
            }

            sw.Stop();
            Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}");
            //0ms 나온다 스트링빌더쪽이 훨씬 효율적*/

            /*try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }*/

            //finally 블록은 예외와 상관없이 항상 무조건 실행된다

            /*try
            {
                int number = int.Parse("NotANumber");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Format Eror: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("항상 실행됩니다.");
            }*/


            /*try
            {
                int num = int.Parse("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error : {ex.Message}");
            }*/

            /*try
            {
                int age = 5;
                
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
            //throw로 직접 예외를 발생시키고 갈수있다
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }*/
        }
    }
}
