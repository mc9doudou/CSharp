using UnityEngine;
namespace Inheritance08
{


    public class AbstractClassDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //추상클래스는 인스턴스 (객체)를 만들수 없습니다
            //ParentClass parent = new ParentClass();
            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "홍길동" };
            if (child.Active = true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }
        }
    }
}
/*
AbstractClass(추상 클래스)
: 자신을 상속 받은 자식클래스 에서 강제로 기능을 추가하도록 한다
: 자식 클래스는 부모 클래스가 지정한 기능을 구현하도록 강제한다
: 추상 클래스는 인스턴스(객체)를 만들수 없습니다
: 추상 클래스는 다른 클래스의 부코 클래스만 사용이 가능하다 

추상 클래스 형식
public abstract class (클래스이름)
{
    
}



*/