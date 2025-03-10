using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 선언
        int[,] intArray;



        //[2] 배열 요소수(크기)생성
        intArray = new int[2, 3];

        //[3] 배열 초기화 
        //0번행
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        //1번행
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;



        //[4] 배열 사용 
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Debug.Log(intArray[i,j]);
            }
            Debug.Log("     ");
        }


        //Debug.Log(intArray[0,0]);


    }
}
/*
//2차원 배열 : 행과 열로 이로어진 배열 
//  1, 2, 3
//  4, 5, 6





*/