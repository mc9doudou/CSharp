using UnityEngine;
namespace Override
{
    //부모 클래스

    public class Animal
    {
        //virtual 표시된 메서드 : 가상 메서드
        public virtual void Eat() => Debug.Log("Animal Eat");

    }
    //자식 클래스
    public class Dog : Animal
    {
        public override void Eat() => Debug.Log("강아지가 밥을 묵는다");
    }

}