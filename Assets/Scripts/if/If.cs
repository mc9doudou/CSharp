using UnityEngine;

//if (���ǹ�) : ���� score�� 60�� �̻��̸� "�հ�"�̶�� ���
//score�� 61���� �ʱ�ȭ
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;
        if (score >= 60){ Debug.Log("�հ�"); };

        /*if(score�� 60�� �̻�)
        {
            "�հ�"�̶�� ���
        }
        */

        int sdore = 61;
        if (sdore >= 60)
        {
            Debug.Log("conguratulation");
        }
    }
}

/*
if�� - ���ǹ� 
���ǽ��� ���϶��� ���๮�� ����˴ϴ�.
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�.

//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶� 
if(���ǽ�)
{
//���๮1
//���๮2
//���๮3
....
}

if(bool)
{
//���๮1
//���๮2
//���๮3
....
}



*/