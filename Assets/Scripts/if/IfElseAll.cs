using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수 하나를 입력받아서 짝수 판별
        int number = 3;

        //짝수 판별식
        if(number % 2 == 0)
        {
            Debug.Log($"{number}는 짝수입니다");
        }
        
        //홀수 판별식
        if(number%2 != 0)
        {
            Debug.Log($"{number}는 홀수");
        }
        else
        {
            Debug.Log($"{number}는 짝수");
        }
        //3의 배수, 5의 배수, 7의 배수 판별식

        int number2 = 28;

        if (number2 % 3 == 0)
        {
            Debug.Log($"{number2}는 3의 배수");
        }
        else if (number2 % 5 ==0)
        {
            Debug.Log($"{number2}는 5의 배수");
        }
        else if (number2 % 7 == 0)
        {
            Debug.Log($"{number2}는 7의 배수");
        }
        else 
        {
            Debug.Log($"{number2}는 3,5,7의 배수가 아닌 수");
        }
    }
}
