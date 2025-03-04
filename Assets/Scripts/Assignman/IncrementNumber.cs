using UnityEngine;

//정수형 변수의 값을 1씩 증가
public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 변수 num을 선언하고 10으로 초기화
        int num = 10;           //num :10
        num++;            //num 1 증가식

        Debug.Log(num);
    }
}
