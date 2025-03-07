using UnityEngine;

//break로 무한 루트 빠져 나오기 
public class BreakInfiniteloop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한루트 - 무한반복 
        /*for (; ; )
        {
        }
        while (true)
        {
        }*/

        int number = 0;

        //number가 5이상 이면 while문 종료
        while (true)    //무한루프
        {
            //반복 실행문 
            Debug.Log(number);

            number++;
            if (number >= 5) 
            {
                break;
            }


        }


    }
}
