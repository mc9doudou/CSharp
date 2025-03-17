using UnityEngine;

public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //다른 클래스의 멤버 호출
        //[1] static 멤버 호출 
        ClassOne.Hi();
        ClassOne.Hi();

        
    }
}
