using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score�� 90�� �̻��̸� A����, 80�̻��̸� B����, 70���̻� �̸�C����, 60�̻��̸� D����,�׿ܿ��� F
        //[0]���� 
        int score = 99;
        char grade = 'A';

        //[1] score�� 90�� �̻��̸� A
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

        Debug.Log($"���б� ����:{grade}");

    }
}
/*

 
 
 
 
 
 
 
 
 */