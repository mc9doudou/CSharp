using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string i = "을 수상하셨습니다.";
        if (score >= 90)
        {
            Debug.Log($"금매달{i}");
        }
        else if (score >= 80)
        {
            Debug.Log($"은매달{i}");

        }
        else if (score >= 70)
        {
            Debug.Log($"동매달{i}");

        }
        else
        {
            Debug.Log("노매달");
        }

    }
}

/*
[Q]
 score가 90 이상이면 금매달 출력, 80이상이변 은매달 출력
70 이상이면 동매달 출력, 그외 나머지는 노메달 출력
score은 85점
 
 [output]
()를 수상하였습니다





 
 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
*/

