using UnityEngine;

//���ڿ� ���� ���(�ٹ̱�): 3����
public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "�浿";
        var lastname = "ȫ";

        //output: "�̸�: ȫ�浿"

        //[1] string ���ϱ� ������ ���
        displayName = "�̸�: " + lastname + firstName;
        Debug.Log(displayName);

        //[2] string.Format() �ż��带 ���
        displayName = string.Format("�̸� : {0}{1}", lastname, firstName);
        Debug.Log(displayName);

        //[3] ���ڿ� ������ ���
        displayName = $"�̸�: {lastname}{firstName}";
        Debug.Log(displayName);
    }
}
