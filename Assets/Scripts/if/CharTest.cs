using UnityEngine;

public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c ='D' ;

        //대문자인지 소문자인지 판별식 만들기 (대문자 판별식)
        if (c >= 'A' && c <= 'Z')
        {
            Debug.Log($"{c}는 대문자 입니다");
        }
        else
        {
            Debug.Log($"{c}는 소문자 입니다");
        }
    }
}
