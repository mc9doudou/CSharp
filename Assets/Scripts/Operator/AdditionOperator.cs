using UnityEngine;

// + :���ϱ� ������ �߰� ���
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello"+"World!!!");  //���ڿ� ���ϱ�
        Debug.Log("Hi"+" "+"Everyone");
        
        Debug.Log("123"+"456");                 //  123456
        Debug.Log("123" + 456);                 //  123456

        Debug.Log(123 + "456"+ 789 + 890);      //  4561802 
        Debug.Log(123 + 456);                   //  579

        Debug.Log("123"+true);
    }
}
