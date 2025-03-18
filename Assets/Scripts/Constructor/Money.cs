using UnityEngine;
namespace Constructor
{
    public class Money
    {
        //기본 생성자
        public Money() : this(1000) //생성자 포워딩(전송)
        {
            Debug.Log("기본 생성자 실행");
        }    
        //매개변수가 있는 생성자 - gold를 입력받아 설정
        public Money(int gold)
        {
            Debug.Log($"Money: {gold:#,###}");
        }


    }
}