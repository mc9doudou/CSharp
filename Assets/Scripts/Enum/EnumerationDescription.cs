using UnityEditor.Rendering.Universal.ShaderGUI;
using UnityEngine;

//우선순위를 관리하는 열거형 생성(선언,만들기)
//사용자 정의 데이터 형식
enum Priority
{
    High,
    Normal,
    Low,
    state,
    sky,
    light,
    moon,bad,simple
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 열거형 변수 선언 및 초기화
        //열거형 변수에 저장되는 값은 정의에서 만들어진 상수 값만 가능하다
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Priority adobe = Priority.simple; 
        int num = (int) adobe;
        string str = adobe.ToString();


        Debug.Log($"Priority.simple : {num},{str}");
        Debug.Log($"{high},{normal},{low}");
        
    }
}
/*


Enum


*/