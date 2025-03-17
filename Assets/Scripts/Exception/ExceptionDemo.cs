using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }*/
        string inputNumber = "3.14";
        int number = 0;

        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"입력한 값은 {number} 입니다");
        }
        catch(System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}는 정수이여야 합니다");
        }

    }
}
/*
Exception 클래스를 이용하여 예외내용 출력하기



*/
