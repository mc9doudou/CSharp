using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("에러가 발생 했습니다.");
        }

        


        
    }
}
/*
예외 처리(Exception Handling) : try - catch - finally 문을 사용
예외(오류)
- 문법 오류
- 런타임 오류
- 알고리즘 오류

구문
try
{
    //명령문
    //....
}
catch
{
    //try 쿠드블록 안에있는 명령문들을 실행중 예외(Exception) 발생시 처리할 내용
    //...
}


*/