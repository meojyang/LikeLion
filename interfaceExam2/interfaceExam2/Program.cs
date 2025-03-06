using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExam2
{

    //인터페이스를 사용하면 기존 코드 변경 없이 새로운 기능 추가가 가능함
    //다양한 결제 시스템 추가

    interface IPayment
    {
        void ProcessPayment();
    }


    class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드로 결제합니다.");
            Console.WriteLine("신용카드로 결제 완료!");
        }
    }


    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("페이팔로 결제합니다.");
            Console.WriteLine("페이팔로 결제 완료!");
        }
    }

    //결제 처리기

    class PaymentProcessor
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
                       
            PaymentProcessor processor = new PaymentProcessor();

            IPayment c = new CreditCardPayment();
            IPayment p = new PayPalPayment();
            
            processor.Pay(c);
            processor.Pay(p);

        }
    }
}
