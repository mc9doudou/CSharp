using System.Collections;
using UnityEngine;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack클래스의 객체(인스턴스, 객체)생성
        Stack stack = new Stack();

        //[2] 데이터 입력
        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        //[3]데이터 꺼내오기
        Debug.Log(stack.Pop()); // 3
        Debug.Log(stack.Pop()); // 2
        Debug.Log(stack.Pop()); // 1

        try
        {
            Debug.Log(stack.Pop());//
        }
        catch(System.Exception ex)
        {
            Debug.Log($"에러내용{ex}");
        }
        //비어있는 스택에서 데이터 꺼내라 (Pop)
        

    }
}
/*
stack 클래스 : LIFO(Last In First Out) 형태로 데이터를 저장 관리하는 클래스
LIFO(Last In First Out) : 후입선출(?), 마지막에 넣은 데이터를 가장 먼저 꺼낸다 
- 주방의 접시를 쌓아놓는 형태의 데이터 구조,우물형 창고 데이터 구조

Push(): 스택 구조에 데이터 입력
Pop(): 스택 구조에서 데이터 출력
Peek(): 스택 구조에서 데이터중 가장 상단(마지막에 입력)의 데이터값 반환
Count(): 스택에 현재 저장되어 있는 데이터 수
Overflow(): 스택이 가득 차 잇을때 발생
Underflow(): 스택이 비었을때 발생

*/
