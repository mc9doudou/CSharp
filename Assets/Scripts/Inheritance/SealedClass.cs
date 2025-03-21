using UnityEngine;
namespace Inheritance07
{
    //Sealed(봉인) 클래스 : 최종 클래스, 더이상 상속되지 못합니다

    public class SealedClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cat 클래스의 인스턴스 생성
            Cat cat = new Cat();
            cat.Eat();

        }
    }
}