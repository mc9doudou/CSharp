using UnityEngine;

public class FunctionScope : MonoBehaviour
{
    string message = "���� ����";  // �ʵ�, ��� ����


    void Start()
    {
        ShowMessage();
        PrintMessage();
        Debug.Log(message);
    }
    //message�� ����ϴ� �Լ�
    void ShowMessage()
    {
        string message = "���� ����";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }
}
/*
���� ����, ���� ���� 
 
 
 
 
 
 
 
 */