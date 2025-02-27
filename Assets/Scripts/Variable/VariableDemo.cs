using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 777; //[1] 변수 선언과 동시에 값 대입 (초기화 )
        Debug.Log(num);
        int i;
        i = 666;
        Debug.Log(i + num);
    }

}
