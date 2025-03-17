using UnityEngine;

//문자열 비교하기 - 2가지 방법
public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPlus";
        
        //[1] 연산자 ( == ) 를 사용
        if(userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("같다");
        }

        //[2] string.Equal() 메서드 사용
        if (string.Equals(userName,inputName,System.StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("같다");
        }
    }
}
