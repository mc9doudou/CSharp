using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A학점, 80이상이면 B학점, 70점이상 이면C학점, 60이상이면 D학점,그외에는 F
        //[0]선언문 
        int score = 99;
        char grade = 'A';

        //[1] score가 90점 이상이면 A
        if (score >=90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Debug.Log($"금학기 성적:{grade}");

    }
}
/*

 
 
 
 
 
 
 
 
 */