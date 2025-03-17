using UnityEngine;



public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*  void Start()
      {   //[2] 두 정수(3,4)의 합을 반환값을 받아 출력하기
          int result = GetSum(3, 4);
          Debug.Log(result);
      }
      //[1] 매개변수, 반환값 이용
      //매개변수로 들어온 두 정수의 합을 반환하는 함수 선언

      int GetSum(int x, int y)
      {
          //int sum = x + y;
          //return sum;
          return (x + y);
      }*/
    /*private void Start()
    {
        double result = GetSum(3.0, 0.14,0.001592);
        Debug.Log(result);
    }

    double GetSum(double x, double y,double z)
    {
        double r = x + y + z;
        return r;
    }*/

    private void Start()
    {
        sum(10, 20);
        sum(first: 10, second:20);
        sum(second: 20, first: 10);

    }
    void sum(int first, int second)
    {
        Debug.Log(first +second);
    }








}
/*
두수의 합을 구하는 함수 만들기




*/