using UnityEngine;

//1, 2, 3, 4, 5, 6...
//n, n-1, n-2...5, 4, 3, 2, 1
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1���� 5���� 1�� ���� 
        for(int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"���� countdown{i}");
        }
        Debug.Log("=====================================");

        //[2] 5���� 1���� 1�� ���� 
        /*for(int i = 5; i > 1-1; i--)
        {
            Debug.Log($"���� countdown{i}");
        }*/

        for (int i = 0; i < 5+1; i++)
        {
            
            Debug.Log($"���� countdown{(5-i)}");
        }




    }
}
