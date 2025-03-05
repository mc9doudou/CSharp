using System;
using UnityEngine;

//NotLogical (���� ������, Not) : ! ���̸� �����̰�, �����̸� ������ ��ȯ
//��� : true, false 
public class NotLogical : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���϶�
        Debug.Log(!true);   //=> false

        //[2] �����϶�
        Debug.Log(!false);  //=> true

        //[3]
        bool bin = false;

        Debug.Log(!bin);        //=> true
        Debug.Log(!!bin);       //=> false
        Debug.Log(!(!(!bin)));  //=>true

        int health = 80;
        int mana = 30;

        if (health > 70 || mana > 30)
        {
            Debug.Log("��ų�� ����� �� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("��ų�� ����� �� �����ϴ�.");
        }

    }
}
