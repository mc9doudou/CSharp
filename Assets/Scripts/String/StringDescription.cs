using UnityEngine;

//String Ŭ����, StringBuilder  Ŭ������ �̿��Ͽ� ���ڿ� �ٷ��
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ڿ� ���� �޼��� -�빮�� ,�ҹ���, �ٲٱ�
        string message = "hello World!!";
        Debug.Log(message);

        //[1] �빮��
        Debug.Log(message.ToLower());
        Debug.Log(message.ToUpper());

        //[3] �ٲٱ�
        Debug.Log(message.Replace("hello","�ȳ��ϼ���").Replace("World","����"));
    }
}
