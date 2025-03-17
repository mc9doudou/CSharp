using NUnit.Framework;
using UnityEngine;

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        Debug.Log(1* 2* 3* 4);
       
        Debug.Log(FactorialFor(4));

        Debug.Log(Factorial(4));
    }

    int FactorialFor(int n)
    {
        int result = 1;

        for(int i= 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    //3항 연산자를 이용한 Factorial 만들기
    int Factor(int n)
    {
        *//* if (n <= 1)
             return 1;
         return n * Factor(n - 1);*//*

        return (n > 1) ? n * Factor(n - 1) : 1;
    }



    //재귀함수 이용 Factorial 값 구하기
    int Factorial(int n)
    {
        //종료 조건 부분 
        if (n == 1 || n == 0)
        {
            return 1;
        }

        //제귀 호출 부분  
        return n * Factorial(n-1);
    }*/

    private void Start()
    {
        Debug.Log(Factorial(4));
        Debug.Log(Fact(4));
    }

    int Factorial(int n)
    {
        int result = 1;
        for (int i = 1 ; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }

    int Fact(int a)
    {
        if (a > 1)
        {
            return a * Fact(a - 1);
        }
        else
        {
            return 1;
        }
    }







}
/*
제귀함수 : 함수가 자신의 코드 블록 안에서 자기 자신을 다시호출(제귀 호출)하는 함수
-제귀함수 매개변수: 매개변수는 감산, 가산이 된다
-재귀함수 코드 블록안에는 재귀함수를 종료 할 수 있는 조건이 필요하다

Factorial(n!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3
4! = 1 * 2 * 3 * 4
n! = 1 * 2 * 3 * 4 *... * n





*/