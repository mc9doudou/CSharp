using UnityEngine;

public class RendomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();

        //������ ������ ���ϱ�
        Debug.Log(random.Next());

        //1~5 �� �ϳ��� �� ���ϱ� 
        Debug.Log(random.Next(5));

        //1~9 �� �ϳ��� �� ���ϱ�
        Debug.Log(random.Next(1,10)); 

      

    }
}
