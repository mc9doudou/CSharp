using UnityEngine;

//�������� Switch���� �Բ� ���� ���Ǿ�����
//�ѱ� ���� �̸� ���
enum Animall
{
    Chicken,
    Dog,
    Penguin

}


public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ���� �� �ʱ�ȭ
        Animall ani = Animall.Chicken;
        PrintAnimal(ani);


    }


    //�Ű����� ������ ������ �޾� �ѱ� �̸� ����ϱ�
    void PrintAnimal(Animall animal)
    {
        switch (animal)
        {
            case Animall.Chicken:
                Debug.Log("��");
                break;
            case Animall.Dog:
                Debug.Log("��");
                break;
            case Animall.Penguin:
                Debug.Log("�ر�");
                break;
        }
    } 


}
