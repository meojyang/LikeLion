using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion26
{
    class Program
    {

        /*class Cup<T>
        {
            public T Content { get; set; }
        }*/


        class SimpleCollection: IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach(var item in data)
                {
                    yield return item; //yield return은 프레임당 하나씩 실행되는것
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


        static void Main(string[] args)
        {

            /*var collection = new SimpleCollection();

            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }*/ //인터페이스를 직접 구현해서 이렇게 쓸수도있다


            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 123 };

            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"CupOfInt: {cupOfInt.Content}");*/

            /*Stack<int> stack = new Stack<int>();

            stack.Push(12);
            stack.Push(123);
            stack.Push(321);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*List<string> names = new List<string> { "alice", "bob", "charlie" };
            names.Add("dog");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            /*//IEnumerator
            //씨샵의 컬렉션을 순회 반복할 수 있는 인터페이스

            ArrayList list = new ArrayList { "Apple", "Bananas", "Kiwi" };
            IEnumerator enumerator = list.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }*/


            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["환갑"] = 60;
            ages["칠순"] = 70;
            ages["팔순"] = 80;


            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/
            //dictionary의 특징

            //null값
            //참조형식은 null을 가질수 있으며, 값형식은기본적으로 null을 가질수없다.

            /*string str = null;

            if(str == null)
                Console.WriteLine("str is null");

            int? nullableInt = null;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            */

            /* string str = null;
            Console.WriteLine(str??"DefaultValue"); //str이 null이면 디폴트밸류 출력

            str = "Hello";
            Console.WriteLine(str?.Length);
            // str이 null인지 체크해서 null이 아니면 길이 출력
            // ? 는 널인지 체크해서 program이 터지지 않게 도와준다*/


            /*//이건 LINQ
            //Language Integrated Query
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
                Console.WriteLine(num);*/

        }
    }
}
