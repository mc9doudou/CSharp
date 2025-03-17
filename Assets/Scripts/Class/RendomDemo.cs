using UnityEngine;

public class RendomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();

        //임의의 정수값 구하기
        Debug.Log(random.Next());

        //1~5 중 하나의 값 구하기 
        Debug.Log(random.Next(5));

        //1~9 중 하나의 값 구하기
        Debug.Log(random.Next(1,10)); 

      

    }
}
