using UnityEngine;

//and, or LogicalOperator(�� ������) - &&, ||, !
//andoperator(And������ ): And (&&) �Ѵ� ���϶��� �� 
//and�������� ����� : ture, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�Ѵ� ���϶��� ��
        Debug.Log(true && true);    //=> true

        //[2]���߿� �ϳ��� �����̸� ����
        Debug.Log(true && false);   //=> false

        //[3]�Ѵ� �����̸� ����
        Debug.Log(false && false);  //=> false 



    }

}
