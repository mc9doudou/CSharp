using UnityEngine;

// +=, -=, *= , /=, %=
public class ShortCutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        //b������ a������ ���� �����϶�
        //b = b + a;
        b += a;

        Debug.Log(b);   //8

        //b ������ a������ ���� �����϶�
        b -= a;

        Debug.Log(b);   //5


    }
}
