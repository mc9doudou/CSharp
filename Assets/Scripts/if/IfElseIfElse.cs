using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // number1,number2 값을 입력받아서
        //[1] number1 크면 number1이 큽니다 출력
        //[2] number2 크면 number2가 큽니다 출력
        //[3] 나머지는 두수의 크기가 같습니다 출력

        // 선언문 
        int number1 = 10;
        int number2 = 10;

        if (number1 > number2)                  //조건식 1
        {
            Debug.Log("number1이 큽니다");
        }   
        else if (number1 < number2)             //조건식 2
        {
            Debug.Log("number2가 큽니다");
        }
        else                                    //기타
        {
            Debug.Log("두수의 크기가 같습니다");
        }

        //실행문 4
    }
}


/*
ElseIf 문 
[1] 조건식 1이 참이면 
선언문 -> 실행문1 -> 실행문 4

[2] 조건식 2가 참이면 
선언문 -> 실행문2 -> 실행문 4

[3] 조건식 1,2가 거짓이면 
선언문 -> 실행문3 -> 실행문 4

[4] 조건식 1 참이고 조건식2 참이면 
선언문 -> 실행문1 -> 실행문 4




*/