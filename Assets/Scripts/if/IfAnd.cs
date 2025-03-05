using UnityEngine;

// &&, || 
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1234;

        //조건식 2개 : number가 1234와 같은가?, number가 1000이상 인가?
        //2가지 조건을 충족 하면 맞습니다.   
        /*if (number == 1234)
        
            if(number >= 1000)
            
                Debug.Log("맞습니다.");
        */


        if (number == 1234 && number >= 1000)
        {
            Debug.Log("맞습니다.");
        }

        //조건식 2개 : number가 1234와 같은가?, number가 1000 이하 인가?
        //2가지 조건을 하나라도 만족하면(||) 실행문 "진행시켜"   

        if (number ==1234 || number <= 1000)
        {
            Debug.Log("진행시켜");
        }

    }
}
