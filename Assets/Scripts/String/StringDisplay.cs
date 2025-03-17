using UnityEngine;

//문자열 묶는 방법(꾸미기): 3가지
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "길동";
        var lastname = "홍";

        //output: "이름: 홍길동"

        //[1] string 더하기 연산자 사용
        displayName = "이름: " + lastname + firstName;
        Debug.Log(displayName);

        //[2] string.Format() 매서드를 사용
        displayName = string.Format("이름 : {0}{1}", lastname, firstName);
        Debug.Log(displayName);

        //[3] 문자열 보간법 사용
        displayName = $"이름: {lastname}{firstName}";
        Debug.Log(displayName);
    }
}
