using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� �ϳ��� �Է¹޾Ƽ� ¦�� �Ǻ�
        int number = 3;

        //¦�� �Ǻ���
        if(number % 2 == 0)
        {
            Debug.Log($"{number}�� ¦���Դϴ�");
        }
        
        //Ȧ�� �Ǻ���
        if(number%2 != 0)
        {
            Debug.Log($"{number}�� Ȧ��");
        }
        else
        {
            Debug.Log($"{number}�� ¦��");
        }
        //3�� ���, 5�� ���, 7�� ��� �Ǻ���

        int number2 = 28;

        if (number2 % 3 == 0)
        {
            Debug.Log($"{number2}�� 3�� ���");
        }
        else if (number2 % 5 ==0)
        {
            Debug.Log($"{number2}�� 5�� ���");
        }
        else if (number2 % 7 == 0)
        {
            Debug.Log($"{number2}�� 7�� ���");
        }
        else 
        {
            Debug.Log($"{number2}�� 3,5,7�� ����� �ƴ� ��");
        }
    }
}
