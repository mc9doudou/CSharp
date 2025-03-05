using UnityEngine;

//OrOperator(Or연산자): || 하나라도 참이면 참 
//결과 :true , false 
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘다 참일때 참
        Debug.Log(true || true);    //=> true

        //[2] 둘중에 하나가 참일때 참
        Debug.Log(true || false);   //=> true
        Debug.Log(false || true);   //=> true

        //[3] 둘다 거짓이면 거짓
        Debug.Log(false || false);  //=> false
    }
}
