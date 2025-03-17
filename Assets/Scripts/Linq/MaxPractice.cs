using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { -2, -5, -3, -7, -1 };
       

        //최대값을 저장하는 변수 max의 초기값: max의 데이터 타입이 가지는 값중 가방 작은값
        int max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];       //두수 비교후 큰값을 max에 저장 
            }
        }

        Debug.Log($"최대값은: {max}");
    }
}
/*
[Q]
입력데이터 {-2,-5,-3,-7,-1}
입력 데이터중에서 최댓값을 구하세요

[output]
최대값: -1

*/