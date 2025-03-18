using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] Ob = { 95, 65, 78, 50, 95 };
        //평균점수 = 총점 / 점수의 갯수
        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < Ob.Length; i++)
        {
            if (Ob[i]>=70 && Ob[i] <= 95)
            {
                sum = sum + Ob[i];
                count++;
            }

        }
        if (count > 0)
        {
            average = sum / (double)count;
        }

        Debug.Log($"평균점수: {average}");
    }

}
/*
[Q] 
입력데이터 {95, 65, 78, 50, 95}

국어점수중 70점이상이고 95점 이하인 점수들의 평균을 구하라

[output] - 소수점이하 2자리 까지
평균점수: average

*/
