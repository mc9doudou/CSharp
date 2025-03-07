using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1] 1차원 배열 선언, 요소수(갯수) 생성, 값 초기화를 동시
        //int[] intArray = new int[3] { 1, 2, 3 };
        //[1-2] 1차원 배열 선언, 요소수(갯수) 생성 생략, 값 초기화를 동시
        //int[] intArray = new int[]{ 1, 2, 3, 4 };
        //[1-3] 1차원 배열 선언, 값 초기화를 동시
        int[] intArray = { 1, 2, 3, 4, 5 };


        //[4] 배열의 사용 
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]}");
        }


    }
}
