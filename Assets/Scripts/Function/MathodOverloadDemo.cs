using UnityEngine;

public class MathodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        Hi();
        Hi("�ݰ����ϴ�.");
        Hi("�����մϴ�", 3);

    }
    //�λ��ϴ� �Լ� "Hi!"�� �����ϱ�
    //�Ű������� ���� �Լ�
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���");
    }
    //�Ű������� �Է¹��� (message)�� �λ� 
    void Hi(string message)
    {
        Debug.Log(message);
    }

    // �Ű������� �Է¹��� (message)�� �Ű������� ���� (count) Ƚ�� ��ŭ �λ�
    void Hi(string message, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }*/

    /*private void Start()
    {
        Hi();
        Hi("Hello World!!");
    }

    void Hi()
    {
        Debug.Log("Good Morning!!");
    }
    void Hi(string msg)
    {
        Debug.Log(msg);
    }
*/

    private void Start()
    {
        Hi();
        Hi("�������!");
        Hi("�ȳ��ϼ���!!", 4);
    }

    void Hi(string msg)
    {
        Debug.Log(msg);
    }
    void Hi(string milk,int num)
    {
        for(int i = 0; i < num; i++)
        {
            Debug.Log(milk);
        }
    }

    void Hi()
    {
        Debug.Log("�ݰ����ϴ�");
    }



}
/*
�λ��ϴ� �Լ� "Hi!"�� �����ϱ�
�Ű������� ���� �Լ�



*/