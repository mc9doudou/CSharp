using UnityEngine;

// Integer(정수형 변수) : 
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //int형 변수가 가질수 있는 가장 작은값 
        int min = -2147483648 ;
        //int형 변수가 가질수 있는 가장 큰값
        int max = 2147483647;
        
        

        Debug.Log("int변수의 최소값" + min);
        Debug.Log("int변수의 최대값" + max);

    }
}
