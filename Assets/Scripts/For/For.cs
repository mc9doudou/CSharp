using UnityEngine;

//1 부터 5까지 1씩 증가하면서 값을 출력하는 프로그램
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
        //1 부터 5까지 1씩 증가하면서 값을 출력 - 5번 반복
        /*for (int i = 0; i < 5; i++)    //5번 반복
        {
            //반복 실행문
            Debug.Log($"count: {i}");
            Debug.Log($"count: {i+1}");
        }*/
        
        /*for(int i =1; i<=5; i++ )
        {
            //반복 실행문
            Debug.Log($"count: {i}");
        }*/

        for(int i = 1; i < 6 ; i++)
        {
            Debug.Log($"count: {i}");
        }
        
    }
}
