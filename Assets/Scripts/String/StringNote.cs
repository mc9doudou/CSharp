using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string ���� str �����ϰ� ������ �ʱ�ȭ
        string str = "";
        str = System.String.Empty;  // ������ ����
        str = " Abc Def Fed Cba ";  // �յڿ� ���� �ϳ��� �־ �� ����

        Debug.Log(str);
        Debug.Log(str.Length);      //���ڿ� ���� ���ϱ�
        Debug.Log(str[5]);          //'D'���� ���
        Debug.Log(str.ToUpper());   //�빮�ڷ� ���
        Debug.Log(str.ToLower());   //�ҹ��ڷ� ���

        //���� ���� ���
        Debug.Log(str.Trim());      //�յ� ���� ���� ����
        Debug.Log(str.TrimStart()); //���ڿ� �պκ� ���� ����
        Debug.Log(str.TrimEnd());   //���ڿ� �޺κ� ���� ����

        //�˻�
        Debug.Log(str.IndexOf('e'));        //'e' �� ��ġ�� �ε��� �������� 
        Debug.Log(str.Substring(5,3));      //5�� index���� 3���� �������� 
        Debug.Log(str.Substring(5));        //5�� �ε������� ������ ��������
        Debug.Log(str.Remove(5,3));         //5�� �䵦������ 3���� ����

        //��
        Debug.Log(str[1] == str[15]);       //false
        Debug.Log("ABC".Equals("Abc"));     //false
        Debug.Log(System.String.Compare("BAC","Bac")); //compare => 0(����), 1(�ٸ�, >), -1(�ٸ�, <)

        //����
        var hi1 = "�ȳ�";
        var hi2 = "�ϼ���";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}",hi1,hi2));

        //format
        Debug.Log(System.String.Format("{0:C}",1000)); //C : ��ȭ(��ȭ)
        Debug.Log(System.String.Format("{0:#,###}",1000000)); //#,### ���ڸ� �޸�

        //�и��ϱ� - ���ڿ� ��ü ���� ���� 
        string[] strArray = str.Trim().Split(' ');
        string strAll = " ";
        foreach(var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;

        }
        Debug.Log(strAll);
    }
}
