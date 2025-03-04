using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LikeLion25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//배열과 컬렉션

            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }*/


            /*//배열이랑 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave"); //이름을 추가해줄수도있고
            names.Remove("Bob"); //기존에 잇던걸 빼줄수도있다

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            /*List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list[1]);
            
            list.Insert(1, 100); //1번 인덱스에 100을 넣고 나머지 2랑 3은 뒤로 밀림
            Console.WriteLine(list[1]);
            Console.WriteLine(list.Count);
            Console.WriteLine(list[0]);

            list.Remove(3);
            foreach(int a in list)
            {
                Console.WriteLine(a);
            }*/

            //스택

            /*Stack<int> stack = new Stack<int>();

            stack.Push(100);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/
            //system.collections using 전에는 이렇게 써야하고
            //스택은 선입후출이라서 3 2 1 100 순으로 출력될거임

            /*Stack s1 = new Stack();
            s1.Push(1);*/
            // System.Collections using 후에는ㅇ ㅣ렇게 써도됨

            /*Queue queue = new Queue();
            queue.Enqueue(1);

            Console.WriteLine(queue.Dequeue());*/

            /*Queue queue = new Queue();

            queue.Enqueue("q");
            queue.Enqueue("w");
            queue.Enqueue("e");
            queue.Enqueue("r");
            queue.Enqueue("점멸");
            queue.Enqueue("평타");

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine(queue.Count);*/

            /*ArrayList arrayList = new ArrayList();

            arrayList.Add(1); //정수
            arrayList.Add("Hello"); //문자열
            arrayList.Add(3.14); //실수

            foreach(var a in arrayList)
                Console.WriteLine("ArrayList 요소 : " + a);

            arrayList.Remove(1);

            foreach (var a in arrayList)
                Console.WriteLine("ArrayList 요소 : " + a);*/


            //Hashtable 클래스
            //키와 값을 같이 저장하는 컬렉션이다.
            //키를 통해 값을 찾을 수 있다.

            Hashtable hashtable = new Hashtable();

            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["포션"] = 20;

            Console.WriteLine("Hashtable 요소: ");

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key}, value: {entry.Value}");
            }

            Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");
            hashtable.Remove("Bob");
        }
    }
}
