using UnityEngine;

public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        //[1] 정수형 배열 선언 
        string[] numbers;

        //[2] 배열의 요소수 생성 - 그릇 갯수 지정 - 크기
        numbers = new string[n];  // 0 ~ (n-1) => [n]개

        //[3] 배열의 저장, 대입 - 초기화
        numbers[0] = "오리";
        numbers[1] = "닭";
        numbers[2] = "뼈";
        numbers[3] = "탱";
        numbers[4] = "탕";
        numbers[5] = "소";

        //[4] 배열의 사용 
        Debug.Log(string.Join(" ", numbers));

    }
}
/*
//Variable (변수) : 프로그램에서 사용하는 데이터를 저장해 놓는 그릇
Array (배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇
선언: 데이터 타입[]  변수명 ;
크기지정: 변수명(이름) = new 데이터타입 [갯수]



*/