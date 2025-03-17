using System.Collections;
using UnityEngine;

public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        //[1] HashTable 클래스에 인수턴스(객체) 생성
        Hashtable hash = new Hashtable();

        //[2] 데이터 넣기 : 정수 형식, 문자열 형식의 인덱스 사용
        hash[0] = "대한민국";
        hash["시이름"] = "서울특별시";
        hash["구이름"] = "강동구";

        /*//[3] 데이터 사용하기
        Debug.Log(hash[0]);
        Debug.Log(hash["시이름"]);
        Debug.Log(hash["구이름"]);*/

        foreach (var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()}-{hash[o]}");
        }



    }
}
/*
HashTable : 정수형식, 문자열 형식의 인덱스를 사용하여 데이터(값)들을 저장, 관리하는 클래스
[0], [1], [2], ["문자열"], ["이름"]




*/