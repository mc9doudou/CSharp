using UnityEngine;
using UnityEngine.UIElements;

public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2���� �迭 ����: ù��° ��Ҽ�(ũ��)�� ���� 
        int[][] intArray = new int[2][];

        //[2] 2���� �迭 (�ι�°)��Ҽ�(ũ��) ���� ���� �����Ѵ� : 
        intArray[0] = new int[3] {1, 2, 3 } ;
        intArray[1] = new int[2] {4, 5 };

        //[3] 2���� �迭 �ʱ�ȭ
        Debug.Log($"�迭�� ����:{intArray.Length}");
       //[4] 2���� �迭 ����ϱ�
       for(int i = 0; i < intArray.Length; i++)
        {
            for(int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
         
            }

            Debug.Log("==========");
        }



    }
}
/*
������ �迭: �迭�� ���̰� �����̴�


*/