using UnityEngine;

//OrOperator(Or������): || �ϳ��� ���̸� �� 
//��� :true , false 
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �Ѵ� ���϶� ��
        Debug.Log(true || true);    //=> true

        //[2] ���߿� �ϳ��� ���϶� ��
        Debug.Log(true || false);   //=> true
        Debug.Log(false || true);   //=> true

        //[3] �Ѵ� �����̸� ����
        Debug.Log(false || false);  //=> false
    }
}
