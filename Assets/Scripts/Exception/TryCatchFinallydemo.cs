using UnityEngine;

public class TryCatchFinallydemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 0;
        int r = 0;

        try     //���ܰ� �߻��� ���ɼ��� �ִ� ��ɹ�
        {
            //[1]
            r = x / y;
            Debug.Log($"{x}/{y}={r}");
        }
        catch   //try �� ���� ���ܰ� �߻��ϸ� catch���� ����
        {
            //[2]
            Debug.Log("���ܰ� �߻� �߽��ϴ�");
        }
        finally //try �� ���� ���ܰ� �߻��ϴ�, ���ϴ� ������� ����
        {
            //[3]
            Debug.Log("���α׷��� ���� �մϴ�");
        }
        
        //try ������ ���ܰ� �߻��ϸ� : [1] -> [2] -> [3]
        //try ������ ���ܰ� �߻� ���ϸ� : [1] -> [3]

    }
}
