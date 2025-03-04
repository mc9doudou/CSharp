using UnityEngine;

public class IncrementPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 0;

        number1--;
        result1 = ++number1;
        Debug.Log("result1: "+result1);  //3

        ++number2;
        result2 = number2--;
        Debug.Log("result2: "+ result2);  //6


    }
}
