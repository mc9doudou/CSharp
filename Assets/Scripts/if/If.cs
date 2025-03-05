using UnityEngine;

//if (조건문) : 만약 score가 60점 이상이면 "합격"이라고 출력
//score은 61으로 초기화
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;
        if (score >= 60){ Debug.Log("합격"); };

        /*if(score가 60점 이상)
        {
            "합격"이라고 출력
        }
        */

        int sdore = 61;
        if (sdore >= 60)
        {
            Debug.Log("conguratulation");
        }
    }
}

/*
if문 - 조건문 
조건식이 참일때만 실행문이 실행됩니다.
조건식이 거짓이면 실행문을 실행하지 않습니다.

//만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라 
if(조건식)
{
//실행문1
//실행문2
//실행문3
....
}

if(bool)
{
//실행문1
//실행문2
//실행문3
....
}



*/