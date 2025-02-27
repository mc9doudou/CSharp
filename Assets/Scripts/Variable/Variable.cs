using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number;         //[1] 정수형 변수 선언하기
        number = 256;       //[2] 변수에 256값 대입(할당)하기
        Debug.Log(number);  //[3] 변수에 값을 화면에 출력하기
    }
}
