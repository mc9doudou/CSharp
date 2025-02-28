using UnityEngine;

//StringInterpolation(문자열 보간법)
public class StringInterpolation: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "문자열 보관법";

        Debug.Log("Message: "+ message);  //[1] "Message: "+ message 문자열 더하기 연산
        Debug.Log($"Message: {message}"); //[2] $"Message: {message}"문자열 보관법으로 출력

        //string.Format
        string msg = string.Format("{0}님,{1}","홍길동","안녕하세요");
        Debug.Log(msg);

    }

   
}
