using UnityEngine;

//순차문 : 위에서 아래로 순서대로 명령문을 실행
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수선언 -초기화
        int kor = 100;      //국어점수
        int eng = 90;       //영어점수
        int total = 0;      //총점   
        double avg = 0.0;   //평균점수

        //[2] 변수에 값 대입
        total = kor + eng;  //총점 구하기
        avg = total / 2.0;  //평균 구하기

        //[3] 변수 사용 
        Debug.Log($"총점: {total}");
        Debug.Log($"평균: {avg}");
            

    }
}

/*
 * = 제어문 : 프로그램의 흐름(순서)를 정하는 구문 
 *  순차문 : 위에서 아래로 순서대로 명령문을 실행
 *  조건문 (if - else, switch) : 조건에 따라 서로 다른 명령문을 실행합니다 
 *  반복문 :
 *  기타 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
*/