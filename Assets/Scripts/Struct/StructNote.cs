using UnityEngine;

//���� �������� �����ϴ� ����ü 
//[1] ����ü ����, ����
struct BusinessCard
{
    public string name;     //�� �̸�
    public int age;         //�� ����
    public string address;  //�� �ּ�

}
public class StructNote : MonoBehaviour
{
    void Start()
    {
        //[2] ����ü ������ ���� ����
        BusinessCard MyCard;


        //[3] ����ü�� �����ִ� �����͵��� �ʱ�ȭ 
        MyCard.name = "ȫ�浿";
        MyCard.age = 90;
        MyCard.address = "ȫ�����";

        //[4] ����ü ��� 
        Debug.Log($"�̸�: {MyCard.name},����: {MyCard.age},�ּ�: {MyCard.address}");

    }
}
