using UnityEngine;



public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*  void Start()
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
      }*/
    /*private void Start()
    {
        double result = GetSum(3.0, 0.14,0.001592);
        Debug.Log(result);
    }

    double GetSum(double x, double y,double z)
    {
        double r = x + y + z;
        return r;
    }*/

    private void Start()
    {
        sum(10, 20);
        sum(first: 10, second:20);
        sum(second: 20, first: 10);

    }
    void sum(int first, int second)
    {
        Debug.Log(first +second);
    }








}
/*
�μ��� ���� ���ϴ� �Լ� �����




*/