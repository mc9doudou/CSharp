using UnityEngine;

//1 ���� 5���� 1�� �����ϸ鼭 ���� ����ϴ� ���α׷�
//count: 1
//count: 2
//count: 3
//count: 4
//count: 5
public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1 ���� 5���� 1�� �����ϸ鼭 ���� ��� - 5�� �ݺ�
        /*for (int i = 0; i < 5; i++)    //5�� �ݺ�
        {
            //�ݺ� ���๮
            Debug.Log($"count: {i}");
            Debug.Log($"count: {i+1}");
        }*/
        
        /*for(int i =1; i<=5; i++ )
        {
            //�ݺ� ���๮
            Debug.Log($"count: {i}");
        }*/

        for(int i = 1; i < 6 ; i++)
        {
            Debug.Log($"count: {i}");
        }
        
    }
}
