using UnityEngine;

//while
public class WhileDesciption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i<3; i++)  �ݺ�Ƚ��: 3 - 0
        //for(int i = 1; i<4; i++)  �ݺ�Ƚ��: 4 - 1
        //for(int i = 1; i<=3; i++) �ݺ�Ƚ��: 3 - 1 + 1
        //for(�����; ���ǽ�; ������)
        /*for (int i = 0; i < 3; i++)
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");
        }*/

        //[1] �ʱ�� 
        int i = 0;

        while (i < 3) //[2]���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");




            //������
        
            i++;
        }

        //���ǽ� �Ǻ�(i:0) �� > ��� > ������ i: 1 > ���ǽ� �Ǻ�(i:1) �� > ��� > ������ i: 2 >
        //���ǽ� �Ǻ�(i:2) �� > ��� > ������ i: 3 > ���ǽ� �Ǻ�(i:3) ���� > while�� ���� 


    }
}
/*
while �� - �ݺ��� 
���ǽ��� true�̸� �ݺ����� �����ϰ� 
        false�̸� while�� �����Ѵ�

while( ���ǽ� )
{   
    //�ݺ� ���๮;

    //���ǽĿ� ���� ���� ������;
}

���ǽ� �Ǻ�(��) > �ݺ��� ���� > ���ǽ� �Ǻ�(��) > �ݺ��� ���� > ���ǽ� �Ǻ�(����) > while�� ����


*/

