using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 45;
        string i = "�� �����ϼ̽��ϴ�.";
        if (score >= 90)
        {
            Debug.Log($"�ݸŴ�{i}");
        }
        else if (score >= 80)
        {
            Debug.Log($"���Ŵ�{i}");

        }
        else if (score >= 70)
        {
            Debug.Log($"���Ŵ�{i}");

        }
        else
        {
            Debug.Log("��Ŵ�");
        }

        string medal = "";

        if (score >= 90)
        {
            medal = "�ݸŴ�";
        }
        else if (score >=80)
        {
            medal = "���Ŵ�";
        }
        else if (score >= 70)
        {
            medal = "���Ŵ�";
        }
        else
        {
            medal = "��Ŵ�";
        }
        Debug.Log($"{medal}�� �����Ͽ����ϴ�.");

    }
}

/*
[Q]
 score�� 90 �̻��̸� �ݸŴ� ���, 80�̻��̺� ���Ŵ� ���
70 �̻��̸� ���Ŵ� ���, �׿� �������� ��޴� ���
score�� 85��
 
 [output]
()�� �����Ͽ����ϴ�





 
 
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

