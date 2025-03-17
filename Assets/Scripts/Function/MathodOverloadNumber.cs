using UnityEngine;

public class MathodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);


    }

    //매개변수로 숫자를 입력 받아 출력하는 함수 : PrintNumber
    //int type의 정수를 매개변수로 입력받아 출력
    void PrintNumber(int number)
    {
        Debug.Log($"Int32:{number}");
    }

    //long type의 정수를 매개변수로 입력받아 출력

    void PrintNumber(long number)
    {
        Debug.Log($"Int64:{number}");
    }

    //float type의 정수를 매개변수로 입력받아 출력
    void PrintNumber(float number)
    {
        Debug.Log($"실수형:{number}");
    }

}
/*
MathodOverloadNumber(메서드 오버로드, 함수 다중 정의)
동일한 이름의 메서드를 매개 변수를 달리해서 여러개 생성하는 것
 
 
 
 
 
 
 
 
 */
