using UnityEngine;

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        System.String s2 = "�ݰ����ϴ�";
        Debug.Log($"{s1},{s2}");
        
        
    }
}
