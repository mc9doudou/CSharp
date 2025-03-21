using UnityEngine;
namespace Override
{
    //Method Override(메서드 제정의, 메서드 오버라이드)
    //부모클래스의 메서드를 재정의(다시 정의)해서 사용하기

    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Child클래스의 인스턴스 생성
            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();
        }
    }
}