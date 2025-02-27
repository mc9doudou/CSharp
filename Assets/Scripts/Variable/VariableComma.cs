using UnityEngine;

//콤마를 사용하여 동일 데이터 형식을 갖는 변수 여러개 만들기

public class VariableComma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int number1;
        //int number2;
        //int number3;
        //콤마로 여러개의 변수를 한줄에 선언
        int number1, number2, number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;
        
        Debug.Log(number1 +","+number2 +","+ number3);
        Debug.Log(number2);
        Debug.Log(number3);
    }
}
