using UnityEngine;

public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = {3, 2, 1, 4, 5 };

        for (int i =0;i<arr.Length;i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("========================");

        //sort - 오름차순 정렬        
        System.Array.Sort(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("========================");

        //Reverse - 역순 정렬

        System.Array.Reverse(arr);
        foreach (var num in arr)
        {
            Debug.Log(num);
        }

    }
}
/*
sort(정렬):
오름차순(1, 2, 3, 4, 5, ...)
내림차순(..., 5, 4, 3, 2, 1)
 
 
 
 
 
 
 
 
 
 */
