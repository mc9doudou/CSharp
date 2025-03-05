using UnityEngine;

//if-else: 
public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            Debug.Log("조건식이 참이면 실행문1을 실행합니다.");
        }
        else
        {
            Debug.Log("조건식이 거짓이면 실행문2를 실행합니다.");
        }

    }
}

/*
else 문 
만약 조건식이 참이면 실행문1을 실행하고 실행문2는 실행하지 않는다.
만약 조건식이 참거짓이면 실행문1을 실행하지 않고 실행문2를 실행한다.

if(조건식)
{
    //실행문 1

}
else 
{
    //실행문 2
}
 
 //실행문 3

1. 조건식이 참이면 
실행문 1 -> 실행문 3

2. 조건식이 거짓이면  
실행문 2 -> 실행문 3


 */ 