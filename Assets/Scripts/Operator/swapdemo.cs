using UnityEngine;

public class swapdemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"ó������ i:{i}, j:{j}");


        //�ڸ� �ٲٱ�
        temp = i;   //�ӽú��� (temp) �� i �� ���� 
        i = j;      //i ������ j �� ����
        j = temp;   //j ������ �ӽú����� ����Ǿ��� i���� ����

        Debug.Log($"���� i:{i},j:{j}");


    }
}

/*
 +,-,*,/���� ������� ���� i,j�ǰ��� ���� �ٲپ �����ϼ���

=�� �̿��ϼ���
temp������ ���� �̿��غ�����

[op]
ó�� i:100, j:200
���� i:200, j:100










 */
