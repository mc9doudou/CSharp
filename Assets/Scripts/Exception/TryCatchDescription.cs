using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("������ �߻� �߽��ϴ�.");
        }

        


        
    }
}
/*
���� ó��(Exception Handling) : try - catch - finally ���� ���
����(����)
- ���� ����
- ��Ÿ�� ����
- �˰��� ����

����
try
{
    //��ɹ�
    //....
}
catch
{
    //try ����� �ȿ��ִ� ��ɹ����� ������ ����(Exception) �߻��� ó���� ����
    //...
}


*/