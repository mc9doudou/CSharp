using UnityEngine;

//"1Ǫ�� 10������ ������ ���� ���ϴ� ���α׷� ����"
//���� ���� 22�̻��̵Ǹ� ���̻� ���� ������ ����
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 10;
        int sum = 0;
        int goal = 22;

        while (i <= n)
        {
            sum += i;
            i++;

            if (sum >= goal)
            {
                break;
            }
        }
        Debug.Log($"1���� {n}������ ��: {sum}");
        
    }
}
