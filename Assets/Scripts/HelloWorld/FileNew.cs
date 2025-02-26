//[1] 네임 스페이스 선언부
using UnityEngine;   //현재 (FileNew )클래스파일에서 unityEngine이라는 네임스페이스를 사용하겠다

//[2]클래스 선언부 

public class FileNew : MonoBehaviour  // 클래스이름(FileNew) 이라는 이름 선언
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[3] (strat)메서드"함수" 선언 : 프로그램을 실행할때 1번만 실행(함수의 시작)
    void Start()
    {
        //[5] 명령문: 콘설창 출력문 
        Debug.Log("Hello Wooooorld!!!");
    }

    // Update is called once per frame
    //[4] (Update)메서드"함수" 선언 : 프로그램 시작후에 매 프레임praim???마다 실행(끝이 없음)
    void Update()
    {
        
    }
}// 코드블록{}
