using UnityEngine;

//Variable (변수) : 프로그램에서 사용하는 데이터를 저장해 놓는 그릇
public class VariableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수를 만든다(선언)
        int i; //i 이름으로 (정수형)변수 만들기

        //[2] 변수에 값을 저장하기(대입, 할당, 초기화)
        i = 114514;

        //[3] 변수에 들어가는 값 사용하기(참조)
        Debug.Log(i);

    }

 
}
/*






 */