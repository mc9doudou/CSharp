using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 777; //[1] ���� ����� ���ÿ� �� ���� (�ʱ�ȭ )
        Debug.Log(num);
        int i;
        i = 666;
        Debug.Log(i + num);
    }

}
