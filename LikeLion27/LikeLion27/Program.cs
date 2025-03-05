using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion27
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            //(n => n) 은
            //int Function(int n)
            //{
            // return n;
            //} 같은 함수라는것

            //string[] sortedNames = names.OrderBy(n => n).ToArray();
            //이렇게 배열로 변환해서 반환받는 방법도 있다.

            foreach(var name in sortedNames)
                Console.WriteLine(name);


            //A로 시작하는 첫번째 문자열을 찾는 방법
            var firstname = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A: {firstname}");*/

            /*//람다를 메소드, 쿼리로 사용하는 방법

            int[] nums = { 5, 3, 8, 1 };

            //메소드 구문

            var sortedNumbers = nums.OrderBy(n => n);
            IOrderedEnumerable<string> sortedNames = names.OrderBy(n == n);
            //이걸 쓰기에는 너무 번거롭고 기니까 var로 간단하게 선언

            var sortedQuery = from n in nums
                                          orderby n
                                          select n;
                                          //약간 sql 문법같은느낌

            //var로 선언해주는건 그냥 편의성을 위해서

            Console.WriteLine("Method  syntax: ");
            foreach(var n in sortedNumbers)            
                Console.WriteLine(n);

            Console.WriteLine("Query syntax: ");
            foreach(var n in sortedQuery)
                Console.WriteLine(n);*/

            /*string[] words = { "apple", "banana", "cherry" };

            //select()로 길이추출

            var lengths = words.Select(w => w.Length);

            foreach (var n in lengths)
            {
                Console.WriteLine(n);
            }

            //select는
            //LINQ 쿼리 연산자중 하나로써
            //각 요소를 변환하여 새로운 컬렉션을 생성한다

            var upperWords = words.Select(w => w.ToUpper());

            foreach(var w in upperWords)
                Console.WriteLine(w);*/

            /*//sum 알고리즘
            int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach(var n in data)
                sum += n;
            
            Console.WriteLine(sum);*/

            /*float[] data = { 80, 75, 66 };

            double avg = data.Average();
            Console.WriteLine($"Average: {avg:F2}");*/

            /*//근삿값 구하기

            int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];
            foreach(var d in data)
            {
                //abs는 절대값으로 만드는 함수
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearest to {target} : {nearest}");*/

            /*//순위를 구하는 rank알고리즘

            int[] scores = { 90, 70, 50, 60, 40 };

            for(int i = 0; i < scores.Length; i++)
            {
                int rank = 1;
                for(int j = 0; j < scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score: {scores[i]}, Rank: {rank}");
            }*/

            /*int[] data = { 5, 2, 6, 7, 1, 9 };

            int target = 8;
            int index = -1;

            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not Found");*/

            //그룹화하기
            string[] fruits = { "apple", "banana", "cherry" };

            var groups = fruits.GroupBy(f => f[0]);

            foreach(var group in groups)
            {
                //그룹의 키(첫글자)를 출력
                Console.WriteLine($"Key : {group.Key}");

                foreach(var item in group)
                {   //그룹에 속한 모든 요소 출력
                    Console.WriteLine($" {item}");
                }
            }


        }
    }
}
