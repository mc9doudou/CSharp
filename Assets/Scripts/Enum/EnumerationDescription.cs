using UnityEditor.Rendering.Universal.ShaderGUI;
using UnityEngine;

//�켱������ �����ϴ� ������ ����(����,�����)
//����� ���� ������ ����
enum Priority
{
    High,
    Normal,
    Low,
    state,
    sky,
    light,
    moon,bad,simple
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ������ ���� ���� �� �ʱ�ȭ
        //������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���� �����ϴ�
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Priority adobe = Priority.simple; 
        int num = (int) adobe;
        string str = adobe.ToString();


        Debug.Log($"Priority.simple : {num},{str}");
        Debug.Log($"{high},{normal},{low}");
        
    }
}
/*


Enum


*/