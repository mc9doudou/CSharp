using UnityEngine;

public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*//매개 변수가 없는함수 호출
        PrintMessage();


        //매개 변수가 있는함수 호출
        string error = "디버그";
        PrintError(error);

        //반환값이 있는 함수 호출
        string errorLog = PrintLog();
        Debug.Log(errorLog);*/

        PrintError("디버그", 6);
        PrintError("디버그",19);
    }

    //Message를 출력하는 함수
    void PrintMessage()
    {
        string message = "디버그";
        Debug.Log(message);
    }


    void PrintError(string message, int level)
    {
        Debug.Log($"애러: {message},레벨: {level}");
    }


    string PrintLog()
    {
        string log = "디버그 로그";
        return log;
    }
}
// DefaultParameter(기본 매개변수, 선택적 매개변수):매개변수 선언할때 동시에 초기화도 한다
// 선택적 매개변수는 함수 호출시 생략이 가능하다. 생략시 초기화 한 값이 사용되어 진다