using TMPro;
using UnityEngine;
namespace Constructor
{
    public class Car
    {
        //필드
        private string color;
        
        //기본 생성자
        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차를 만듭니다");

        }
        //매개변수가 있는 연산자
        public Car(string _color)
        {
            this.color = _color;
            Debug.Log($"{color}색 자동차를 만듭니다");
        }

        //메서드 - 사용
        public void Run()
        {
            Debug.Log($"{color}색 자동차가 달립니다");
        }

        //소멸자
        ~Car()
        {
            Debug.Log($"{color}색 자동차를 페차합니다");
        }


    }
}