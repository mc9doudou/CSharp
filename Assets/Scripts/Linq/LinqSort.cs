using System.Linq;
using UnityEngine;
using System.Collections.Generic;

public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 배열을 오름차순으로 정렬
        string[] colors = { "Red", "Green", "Blue" };

        //오름차순
         
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);


        foreach (var n in sortedColors)
        {
            Debug.Log(n);
        }

        IEnumerable<string> sortedColors2 = colors.OrderByDescending(s => s);

        foreach (var n2 in sortedColors2)
        {
            Debug.Log(n2);
        }


    }
}
/*
sort : 정렬

*/