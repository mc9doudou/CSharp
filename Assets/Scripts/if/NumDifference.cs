using UnityEngine;

//2개의 정수의 차이를 양의 정수로 구하세요 
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = -3;
        int second = -8;
        int diff = 0;       //두수의 차이값 

        //큰수 판별식 
        if (first >= second)
        {
            diff = first - second; 
           
        }
        else
        {
            diff = second - first; 
            
        }
        Debug.Log($"diff: {diff}");

    }
}
