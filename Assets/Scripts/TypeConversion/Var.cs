using UnityEngine;

//Var : 암시적으로 형식화된 로컬 변수
//var 선언시 데이터 초기화를 반드시 한다
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "홍길동";       //변수에 입력되는 값("홍길동")을 보고 name변수를 string 형식으로 결정합니다.
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 'A';        //변수에 입력되는 값("A")을 보고 version변수를 char 형식으로 결정합니다.   
        Debug.Log(version);
        Debug.Log(name.GetType());

        var studio = 3.14;        //변수에 입력되는 값("3.14")을 보고 studio변수를 double 형식으로 결정합니다.  
        Debug.Log(studio);
        Debug.Log(studio.GetType());

        var matrue = 258888888888888886;         //변수에 입력되는 값("256")을 보고 matrue변수를 int 형식으로 결정합니다.
        Debug.Log(matrue);
        Debug.Log(matrue.GetType());

        var ASD = true;           //변수에 입력되는 값("true")을 보고 ASD변수를 bool 형식으로 결정합니다.
        Debug.Log(ASD);
        Debug.Log(ASD.GetType());



    }
}
