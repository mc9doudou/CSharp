using UnityEngine;

public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        //[1] ������ �迭 ���� 
        string[] numbers;

        //[2] �迭�� ��Ҽ� ���� - �׸� ���� ���� - ũ��
        numbers = new string[n];  // 0 ~ (n-1) => [n]��

        //[3] �迭�� ����, ���� - �ʱ�ȭ
        numbers[0] = "����";
        numbers[1] = "��";
        numbers[2] = "��";
        numbers[3] = "��";
        numbers[4] = "��";
        numbers[5] = "��";

        //[4] �迭�� ��� 
        Debug.Log(string.Join(" ", numbers));

    }
}
/*
//Variable (����) : ���α׷����� ����ϴ� �����͸� ������ ���� �׸�
Array (�迭) : �ϳ��� �̸����� ���� ������ ������ ������ ������ ���� �׸�
����: ������ Ÿ��[]  ������ ;
ũ������: ������(�̸�) = new ������Ÿ�� [����]



*/