using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        do
        {   //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            //������
            i++;
        }
        while (i < 3);

        //i:0 > ��� > i:1 > i<3(��) > ��� > i:2 > i<3(��) > ��� > i:3 > i<3(����) > ����


        
    }
}
/*
do- while�� - �ݺ���
���� �ݺ� ���๮�� 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ����� �����ϰ� 
        false�̸� while�� �����Ѵ�

do 
{
    //�ݺ� ���๮;
}
while (//���ǽ� );









*/