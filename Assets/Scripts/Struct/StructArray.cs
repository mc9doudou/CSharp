using Unity.VisualScripting;
using UnityEngine;

//[1] 구조체 정의, 선언: 고객의 데이터를 관리하는 구조체
 struct UserInfo
{
    public string Name;     //고객 이름
    public int Age;         //고객 나이
    //....

}


public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        //[1] 구조체 변수 선언
        UserInfo info;
        //[2] 초기화
        info.name = "홍길동";
        info.age = 200;
        //[3] 구조체 사용
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);

        //[1] 구조체의 배열 변수 선언, 배열의 요소수(크기) 생성
        UserInfo[] userInfos = new UserInfo[2];
        //[2] 구조체 배열 초기화
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;
        userInfos[1].name = "임꺼쩡";
        userInfos[1].age = 33;

        //[3] 구조체 배열 사용
        for(int i = 0; i < userInfos.Length; i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            PrintUserInfo(userInfos[i]);
        }
    }*/

    //고객의 명단을 출력하는 함수 
    /*void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는 {age}살 입니다");
    }
    
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}님의 나이는 {userInfo.age}살 입니다");
    }*/

    private void Start()
    {
        BusinessCard biz;
        biz.name = "백승수";
        biz.age = 19;
        Debug.Log($"{biz.name},{biz.age}");

        BusinessCard[] names = new BusinessCard[2];
        names[0].name = "이세영"; names[0].age = 30;
        names[1].name = "권경민"; names[1].age = 39;
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log($"{names[i].name},{names[i].age}");
        }





    }












}
