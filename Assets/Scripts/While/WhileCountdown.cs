using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� ���� 
        //�ʱ��
        int i = 1;
                
        while (i <= 5)  //���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log($"ī��Ʈ�ٿ�: {i}");
            
            //������
            i++;
        }

        Debug.Log("========================================");
        //[2] 5���� 1���� 1�� ���� 
        //�ʱ��
        int j = 5;
        while (j >=1)
        {   
            Debug.Log($"ī��Ʈ�ٿ�: {j}");

            j--;

        }

       /* int a = 0;
        while (a <= 5)
        {
            Debug.Log($"ī��Ʈ�ٿ�: {5-a}");

            a++;
        }
        */


    }
}
