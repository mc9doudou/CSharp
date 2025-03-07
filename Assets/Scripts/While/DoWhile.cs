using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        do
        {   //반복 실행문
            Debug.Log("안녕하세요");

            //증감식
            i++;
        }
        while (i < 3);

        //i:0 > 출력 > i:1 > i<3(참) > 출력 > i:2 > i<3(참) > 출력 > i:3 > i<3(거짓) > 종료


        
    }
}
/*
do- while문 - 반복문
먼저 반복 실행문을 1번 실행한다
조건식이 true이면 반복문은 실행하고 
        false이면 while문 종료한다

do 
{
    //반복 실행문;
}
while (//조건식 );









*/