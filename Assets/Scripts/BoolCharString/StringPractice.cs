using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 3; // int�� ���� number �����ϰ� 3���� �ʱ�ȭ�Ѵ�
        string AGE = "Ȧ��"; // string�� ���� result �����ϰ� "Ȧ��"�� �ʱ�ȭ


        Debug.Log($"{number}��(��){AGE}�Դϴ�.");
    }
}

/*
[Q]
3, Ȧ���� ������ �����ϰ� �����մϴ�
���ڿ� �������� �̿��ؼ� ����� ������ ���

[output]
3��(��) Ȧ���Դϴ�.


*/