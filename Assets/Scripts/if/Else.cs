using UnityEngine;

//if (���ǹ�) : ���� score�� 60�� �̻��̸� "�հ�"�̶�� ����ϰ� 
//�ƴϸ� "���հ�"�̶�� ���
//score�� 61���� �ʱ�ȭ
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 26;     //[1]
        //���� score�� 60�� �̻��̸� 
        if (score >= 60)
        {
            Debug.Log("�հ�");    //[2]
        }
        else if (score > 30)            //if(score <60)
        {
            Debug.Log("���հ�");   //[3]
        }
        else 
        {
            Debug.Log("����");
        }
            Debug.Log("����");            //[4]

    }
}

// score = 59; : [1] -> [3] -> [4] 
// score = 61; : [1] -> [2] -> [4]