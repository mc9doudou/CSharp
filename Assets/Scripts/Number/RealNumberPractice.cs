using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double Double;
        Double = 3.14D;
        Debug.Log("double: "+Double);

        float Float;
        Float = 3.14F;
        Debug.Log("float: "+Float);

        decimal Decimal;
        Decimal = 3.14M;
        Debug.Log("decimal: "+Decimal);


    }
}
/*
[Q]
�Ǽ��� �� float 3.14, double 3.14, decimal 3.14 �� ����ϱ�

[output]
float 3.14
double 3.14
decimal 3.14
*/