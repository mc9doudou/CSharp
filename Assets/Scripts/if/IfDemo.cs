using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 10;

        //만약 x가 10이면 'x는 10입니다' 를 출력

        if (x == 10)
        {
            Debug.Log($"x는 {x}입니다.");
        }

        //만약 x가 20이 아니면 x는 20이 아닙니다 츨력

        if (x != 20)
        {
            Debug.Log("x는 20이 아닙니다.");
        }



    }
}

/*

 
 
 
 
 */  