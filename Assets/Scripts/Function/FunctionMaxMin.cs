using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū���� {max}�̴�.");
    }
    int GetMax(int x,int y)
    {
        *//*
         * int maxValue;
        if (x > y)
        {
            maxValue = x;
        }
        else
        {
            maxValue = y;
        }
        return maxValue;*//*

        //3�� ������
       *//* int maxValue = (x > y) ? x : y;
        Return maxValue;*//*

        //return (x > y) ? x : y;

        if(x > y){ 
    
        return x;
        }
        else
        {
            return y;
        }
    }*/
    private void Start()
    {
        Debug.Log($"3�� 5�� �ִ밪�� {Max(3,5)}");
        Debug.Log($"-3�� -5�� �ּҰ��� {Min(-3, -5)}");

    }
    int Max(int x,int y)
    {
       if (x > y)
       {
            return x;
       }
       else
       {
            return y;
       }
    }

    int Min(int x, int y)
    {
        if (y > x)
        {
            return x;
        }
        else
        {
            return y;
        }
    }












}
/*
[Q]
1. �Ű������� �Է� ���� �ΰ��� ������ ū ���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է� ���� �ΰ��� ������ ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է¹޾� ū ���� ����ϱ�
4. -3, -5�� �Է¹޾� ���� ���� ����ϱ�

[output]
3�� 5�� ū���� (��ȯ��) �̴�
-3�� -5 �� ���� ����(��ȯ��) �̴� 


 
 */
