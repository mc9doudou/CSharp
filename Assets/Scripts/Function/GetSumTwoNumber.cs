using UnityEngine;



public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //[2] �� ����(3,4)�� ���� ��ȯ���� �޾� ����ϱ�
        int result = GetSum(3, 4);
        Debug.Log(result);
    }
    //[1] �Ű�����, ��ȯ�� �̿�
    //�Ű������� ���� �� ������ ���� ��ȯ�ϴ� �Լ� ����

    int GetSum(int x, int y)
    {
        //int sum = x + y;
        //return sum;

        return (x + y);
    }

}
/*
�μ��� ���� ���ϴ� �Լ� �����




*/