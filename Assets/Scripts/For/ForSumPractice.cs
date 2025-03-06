using UnityEngine;


public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        for (int i = 1; i < n + 1; i++)
        {

            /*if (i % 3 == 0 || i % 4==0)
            {

                sum = sum + i;
            }  */
            if (i % 3 == 0)
            {
                sum = sum + i;
            }

            else if(i%4 == 0)
            {
                sum = sum + i;
            }

        }

        Debug.Log($"합은 {sum}");


    }
}
/*
[Q]
1부터 100까지의 정수중에서 3의 배수 또는 4의 배수를 구해서 합하는 프로그램 구현 
 
 [output]
 합은 {}
 
 
 
 
 
 
 */