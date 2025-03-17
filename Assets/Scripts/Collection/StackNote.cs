using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack 클래스의 인스턴스(객체, 개체) 사용 
        Stack stack = new Stack();

        //[2] Push로 데이터 저장 
        stack.Push("대한민국");
        stack.Push("서울특별시");
        stack.Push("강동구");

        //[3]스택의 제일 상단(마지막 입력한) 데이터를 반환 
        Debug.Log($"{stack.Peek()},{stack.Count}");

        //[4] Pop() 
        stack.Pop();

        if (stack.Count> 0)
        {
            stack.Pop();
            Debug.Log($"{stack.Peek()},{stack.Count}");
        }


        //[7] Clear():스택 비우기
        stack.Clear();
        Debug.Log($"{stack.Peek()},{stack.Count}");

    }
}

