using UnityEngine;

public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number;
        number = 7;

        //int�� ���� x�� �����ϰ� 255�� �ʱ�ȭ
        int x = 255;

        //byte�� ���� y�� �����ϰ� x�� ������ �ʱ�ȭ
        //byte�������: 0~255 
        byte y = (byte)x;

        Debug.Log(x + " -> " + y);

        Debug.Log(number);
    }

}
