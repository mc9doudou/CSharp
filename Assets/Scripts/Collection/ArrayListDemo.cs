using UnityEngine;
using System.Collections;

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ArrayList 클래스의 인스턴트(객체, 개체) 생성  
        ArrayList list = new ArrayList();

        //[2] 데이터 넣기: Add()
        list.Add("서울특별시");
        list.Add("강동구");
        list.Add("동동");

        //[3] 데이터 사용 
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
        

    }
}
/*
ArrayList 클래스 : 배열 처럼 사용이 가능(인덱스 사용)
Add() 데이터 넣기




*/
