using UnityEngine;

public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number;
        number = 7;

        //int형 변수 x를 선언하고 255로 초기화
        int x = 255;

        //byte형 변수 y를 선언하고 x의 값으로 초기화
        //byte저장범워: 0~255 
        byte y = (byte)x;

        Debug.Log(x + " -> " + y);

        Debug.Log(number);
    }

}
