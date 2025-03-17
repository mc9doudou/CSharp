using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LinqSortList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 전용 List 클래스의 인스턴스(객체) 생성 및 초기화

        List<string> colors = new List<string>{ "Red,Blue,Green"};

        var sortedColors = colors.OrderByDescending(c => c);

        foreach (var c in sortedColors)
        {
            Debug.Log(c);
        }

    }
}
/*


*/