using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_event
{
    class Program
    {

        //델리게이트 정의 - 메시지 출력을 위한 메소드를 참조
        //string 매개변수를 받고 반환값이 없는 (void)메소드를 참조할 수 있는 타입


        delegate void MessageHandler(string message);

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메시지: {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메시지 : {message.ToUpper()}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("==== 간단한 델리게이트와 이벤트 예제 ====");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트1");

            //델리게이트 변수 선언 및 메소드 연결
            //DisplayMessage 메소드를 messageHandler 변수에 할당

            MessageHandler messageHandler = DisplayMessage;

            //델리게이트 호출 - 연결된 메소드가 실행됨
            messageHandler("안녕하세요");

            //델리게이트에 다른 메소드 추가 (멀티캐스트 델리게이트)
            // += 연산자로 메소드 추가

            messageHandler += DisplayUpperMessage;

            //여러 메소드가 연결된 델리게이트 호출
            //등록된 모든 메소드가 순서대로 호출됨
            Console.WriteLine("여러 메소드 호출: ");
            messageHandler("Hello ");

        }
    }
}
