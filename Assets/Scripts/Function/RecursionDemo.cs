using NUnit.Framework;
using UnityEngine;

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        Debug.Log(1* 2* 3* 4);
       
        Debug.Log(FactorialFor(4));

        Debug.Log(Factorial(4));
    }

    int FactorialFor(int n)
    {
        int result = 1;

        for(int i= 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    //3�� �����ڸ� �̿��� Factorial �����
    int Factor(int n)
    {
        *//* if (n <= 1)
             return 1;
         return n * Factor(n - 1);*//*

        return (n > 1) ? n * Factor(n - 1) : 1;
    }



    //����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        //���� ���� �κ� 
        if (n == 1 || n == 0)
        {
            return 1;
        }

        //���� ȣ�� �κ�  
        return n * Factorial(n-1);
    }*/

    private void Start()
    {
        Debug.Log(Factorial(4));
        Debug.Log(Fact(4));
    }

    int Factorial(int n)
    {
        int result = 1;
        for (int i = 1 ; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }

    int Fact(int a)
    {
        if (a > 1)
        {
            return a * Fact(a - 1);
        }
        else
        {
            return 1;
        }
    }







}
/*
�����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ�ȣ��(���� ȣ��)�ϴ� �Լ�
-�����Լ� �Ű�����: �Ű������� ����, ������ �ȴ�
-����Լ� �ڵ� ��Ͼȿ��� ����Լ��� ���� �� �� �ִ� ������ �ʿ��ϴ�

Factorial(n!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3
4! = 1 * 2 * 3 * 4
n! = 1 * 2 * 3 * 4 *... * n





*/