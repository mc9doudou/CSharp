using UnityEngine;

//1부터 20까지의 합을 구하는 프로그램 구현 
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1무터 n(20) 까지의 합을 구하는 프로그램 구현
        // 1 + 2 + 3... n-1 + n
        int n = 100;
        int sum = 0;

        for(int i = 1; i < n+1; i++ )
        {
            sum = sum + i;
        }

        Debug.Log($"합은 {sum} 입니다");

    }
}
