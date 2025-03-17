using UnityEngine;

public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 현재 시간 출력
        Debug.Log($"현재시간:{System.DateTime.Now}");

        //[2] 현재 년, 월, 일, 시, 분, 초 출력
        Debug.Log(System.DateTime.Now.Year);
        Debug.Log(System.DateTime.Now.Month);
        Debug.Log(System.DateTime.Now.Day);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);

        //[3] DateTime 구조체의 변수를 선언해서 사용
        System.DateTime now = System.DateTime.Now;
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());
    }
}
/*
내장형 구조체(DateTime) 사용
*/