using UnityEngine;

public class FunctionDescription : MonoBehaviour
{
    //[1] show 메서드(함수) 선언, 정의 
    /*void Show()
    {
        Debug.Log("Hello World...");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show 함수 호출
        Show();
        
    }*/

    static void Show()
    {
        Debug.Log("Hello World!!!");
    }

    static void Main()
    {
        Show();
    }
}
/*
Function(함수) / Method(메서드)
: 반복해서 사용하도록 만들어진 하나이상의 명령문으로 구성된 코드블록
{}

- 내장 함수     : 닷넷(C#)에서 제공하는 함수, 유니티에서 제공하는 함수
- 사용자 함수   : 개발자가 만드는 함수

-매개변수가 없는 함수 
-매개변수가 있는 함수
-반환값이 있는 함수

void 함수이름()
{
    // 하나 이상의 명령문
    //....
}

void 함수이름(매개변수)
{
    //하나 이상의 명령문
    //....
}

(데이터 타입) 함수이름(매개변수)
{
    //하나 이상의 명령문
    //....

    return 변수(값);

}

//함수 구성
입력 > 처리(연산) > 출력

//함수(메서드)
[1] 함수 선언(기능 구현) 
[2] 함수 호출(기능 사용)


*/