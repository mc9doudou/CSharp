using Unity.VisualScripting;
using UnityEngine;

//[1] ����ü ����, ����: ���� �����͸� �����ϴ� ����ü
 struct UserInfo
{
    public string Name;     //�� �̸�
    public int Age;         //�� ����
    //....

}


public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        //[1] ����ü ���� ����
        UserInfo info;
        //[2] �ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 200;
        //[3] ����ü ���
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);

        //[1] ����ü�� �迭 ���� ����, �迭�� ��Ҽ�(ũ��) ����
        UserInfo[] userInfos = new UserInfo[2];
        //[2] ����ü �迭 �ʱ�ȭ
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "�Ӳ���";
        userInfos[1].age = 33;

        //[3] ����ü �迭 ���
        for(int i = 0; i < userInfos.Length; i++)
        {
            //PrintUserInfo(userInfos[i].name, userInfos[i].age);
            PrintUserInfo(userInfos[i]);
        }
    }*/

    //���� ����� ����ϴ� �Լ� 
    /*void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age}�� �Դϴ�");
    }
    
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}���� ���̴� {userInfo.age}�� �Դϴ�");
    }*/

    private void Start()
    {
        BusinessCard biz;
        biz.name = "��¼�";
        biz.age = 19;
        Debug.Log($"{biz.name},{biz.age}");

        BusinessCard[] names = new BusinessCard[2];
        names[0].name = "�̼���"; names[0].age = 30;
        names[1].name = "�ǰ��"; names[1].age = 39;
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log($"{names[i].name},{names[i].age}");
        }





    }












}
