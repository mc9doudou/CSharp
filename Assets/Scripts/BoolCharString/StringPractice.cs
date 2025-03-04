using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 3; // int형 변구 number 선언하고 3으로 초기화한다
        string AGE = "홀수"; // string형 변수 result 선언하고 "홀수"로 초기화


        Debug.Log($"{number}은(는){AGE}입니다.");
    }
}

/*
[Q]
3, 홀수를 변수에 선언하고 저장합니다
분자열 보관법을 이용해서 저장된 데이터 출력

[output]
3은(는) 홀수입니다.


*/