using UnityEngine;

public class ArrayConvertAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 배열을 정수형 배열로 변경
        string[] strArray = { "10", "20", "30" };
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        foreach (int i in intArray)
        {
            Debug.Log(i);
        }


    }
}
