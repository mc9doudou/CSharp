using UnityEngine;

//Var : �Ͻ������� ����ȭ�� ���� ����
//var ����� ������ �ʱ�ȭ�� �ݵ�� �Ѵ�
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "ȫ�浿";       //������ �ԷµǴ� ��("ȫ�浿")�� ���� name������ string �������� �����մϴ�.
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 'A';        //������ �ԷµǴ� ��("A")�� ���� version������ char �������� �����մϴ�.   
        Debug.Log(version);
        Debug.Log(name.GetType());

        var studio = 3.14;        //������ �ԷµǴ� ��("3.14")�� ���� studio������ double �������� �����մϴ�.  
        Debug.Log(studio);
        Debug.Log(studio.GetType());

        var matrue = 258888888888888886;         //������ �ԷµǴ� ��("256")�� ���� matrue������ int �������� �����մϴ�.
        Debug.Log(matrue);
        Debug.Log(matrue.GetType());

        var ASD = true;           //������ �ԷµǴ� ��("true")�� ���� ASD������ bool �������� �����մϴ�.
        Debug.Log(ASD);
        Debug.Log(ASD.GetType());



    }
}
