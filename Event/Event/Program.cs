using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{

    class Character
    {
        //캐릭터의 속성
        public string Name { get; private set; }

        public int Health { get; private set; }

        //이벤트 정의 - 캐릭터가 데미지를 입었을 때 발생
        //EventHandler <- C#에서 제공하는 기본 델리게이트 타입
        //이벤트는 외부 직접 호출 불가능, +=와 -=연산자로만 접근 가능

        public event EventHandler OnDamaged;

        //생성자
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        //데미지를 입는 메소드

        public void TakeDamage(int amount)
        {
            //체력 감소
            Health -= amount;

            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력: {Health}");

            //이벤트 발생 (구독자가 있는 경우) 
            //(?.) 물음표 연산자를 통해서 OnDamaged가 null이 아닐때만 Invoke 메소드를 호출
            //EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자

            OnDamaged?.Invoke(this, EventArgs.Empty);
        }


    }


    class Program
    {
        // 이벤트 핸들러 메소드
        //EventHandler 델리게이트와 일치하는 시그니처를 가져야함
        //sender 부분을 만들거다 : 이벤트를 발생시킨 객체 (이 프로그램에선 Character가 객체임)
        //invoke 부분에 마우스 올려보면 sender가 매개변수임

        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //sender를 character타입으로 형변환
            Character character = (Character)sender;

            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다.");
        }


        static void Main(string[] args)
        {
            //캐릭터 생성
            Character hero = new Character("용사", 100);

            //이벤트 구독 +=
            //이벤트가 발생했을때 실행될 메서드 등록

            hero.OnDamaged += Hero_OnDamaged;

            //데미지 입히기
            //TakeDamage 메소드 내에서 OnDamaged 이벤트가 발생함

            hero.TakeDamage(30);

            //이벤트 구독 취소
            //이벤트 발생해도 메소드 호출 안됨

            hero.OnDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 구독 취소");
            hero.TakeDamage(20); //이벤트 발생함수는 실행하지만 내용은 실행안함




        }
    }
}
