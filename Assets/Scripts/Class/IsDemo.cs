using UnityEngine;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;
        Debug.Log(o);

        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);

        object s = "�ȳ��ϼ���";
        object j = 4567;

        if (s is string)
        {
            Debug.Log($"[1]{s}�� null�� �ƴϸ� ���ڿ� �������� ��ȯ�� �����մϴ�");
        }

        if (j is int)
        {
            Debug.Log($"[2]{j}�� null�� ���������� ��ȯ�� �����մϴ� ");
        }

    }
}
/*
�� ����(vaule ytpe) : ��ü�� �� ��ü�� ��� �ڴ� ����
���� ����(reference type) : ��ü�� ���� ��� �ְ� �� �ٸ� ��ü�� ����Ʈ�� �ٶ󺸴� ����

object ������ ���� : object ������ �������� ��� ������ ������ ���� ����(�Ҵ�) ����
�ڽ�(boxing)      : �� ������ �����͸� ���� ������ �����ͷ� �����ϴ°�
��ڽ�(unboxing)  :���� ������ �����͸� �� ������ �����ͷ� �����ϴ°� - ĳ����,ĳ��Ʈ


is ������ : ���� ���ϱ� 
- Ư�� �������� �ƴ����� ��
- Ư�� �������� ��ȯ�� �����ϸ� true, �׷��� ������ false; 


*/