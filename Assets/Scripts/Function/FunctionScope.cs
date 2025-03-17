using UnityEngine;

public class FunctionScope : MonoBehaviour
{
    string message = "전역 변수";  // 필드, 멤버 변수


    void Start()
    {
        ShowMessage();
        PrintMessage();
        Debug.Log(message);
    }
    //message를 출력하는 함수
    void ShowMessage()
    {
        string message = "지역 변수";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }
}
/*
전역 변수, 지역 변수 
 
 
 
 
 
 
 
 */