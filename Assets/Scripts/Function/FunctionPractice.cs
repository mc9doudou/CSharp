using Unity.Mathematics;
using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    int x = 5;
    int y = 3;
    void Start()
    {
        int result = 0;
        result = Add(x, y);
        Debug.Log(result);

        result = Substract(x, y);
        Debug.Log(result);

        result = Devide(x, y);
        Debug.Log(result);
        
        result = Remainder(x, y);
        Debug.Log(result);


    }

    int Add(int x,int y)
    {
        return x + y;
    }

    //ȭ��ǥ �Լ�, ���ٽ�, ����� �Լ�
    int Substract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Devide(int x, int y) => x / y;
    int Remainder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);

    /*void Add()
    {
        Debug.Log(a + k);
    }

    void Subtract()
    {
        Debug.Log(a - k);
    }
    void Multiply()
    {
        Debug.Log(a * k);
    }
    void Devide()
    {
        Debug.Log(a / k);
    }
    void Remainder()
    {
        Debug.Log(a % k);
    }*/

}

/*
[Q]
��Ģ ������ ���ϴ� �Լ� �����
+, -, *, /, %
�ΰ��� ������ �Է¹޾� +, -, *, /, % ����Ͽ� 
������� ��ȯ�ϴ� �Լ� �����
Add, Subtract, Multiply, Devide, Remainder

�Է°�: 5, 3
[output]

 
 
 
 
*/