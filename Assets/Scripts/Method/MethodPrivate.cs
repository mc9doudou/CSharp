using UnityEngine;

namespace method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스 생성
            Dog cat = new Dog();

            cat.Eat();          //[1] public 메서드 호출 가능
            cat.weight = 30;    //[2] public 필드 접근 가능

            //cat.Digest();     //[3] private한 메서드 호출 불가

            

            



        }
    }
}


