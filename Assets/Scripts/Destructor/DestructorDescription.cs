using UnityEngine;

namespace Constructor
{
    public class DestructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //DestructorTest 클래스의 인스턴스 생성
            DestructorTest destructorTest = new DestructorTest();

            //인스턴스 사용
            destructorTest.Run();


            //GC.Collect - DestructorTest 클래스의 소멸자 호출
            //destructorTest.~DestructorTest();

        }

    }

}
/*
Destructor(소멸자) 
: 클래스가 사용된후 가장 마지막에 호출되는 메서드
: 생성된 인스턴스(객체)가 메모리상에서 없어질때 호출되는 메서드 
: 클래스에서 사용된 메모리 해제 등...
c#에서 메모리 해제란?
GC(가비지 컬렉터)가 메모리 해제 역할을 대신 해줍니다...

Destructor(소멸자) 형식
class className
{
    //소멸자
    ~className()
    {
        //개체가 소멸할때 필요한 기능 수행 
    }
}

*/