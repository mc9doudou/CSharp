using System.Linq;
using UnityEngine;

public class LinqCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수에서 true값의 갯수, false값의 개수 구하기
        bool[] blns = { true, false, true, false, true };

        //전체 요소수 갯수
        Debug.Log(blns.Count());
        //true값의 갯수
        Debug.Log(blns.Count(b => b==true));    //3
        //false값의 갯수
        Debug.Log(blns.Count(a => a==false));    //3
        

    }
}
