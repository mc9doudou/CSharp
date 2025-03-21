using UnityEngine;
namespace Inheritance04
{


    public class ParentClass : System.Object
    {
        protected void PrintMessage()
        {
            Debug.Log("부모 클래스에서 정의한 내용");
        }

    }
}

/*
접근 제한자: public, private, protected
protected : 상속받은 자식 클래스{} 코드 블록 에서 만 접근 가능, 사용 가능



*/