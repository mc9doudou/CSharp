using UnityEngine;

//Struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, 
//�Ǵ� �Լ����� ��� �����ϴ� �׸�(������ ����), ������ Ȯ��
//[1] ����ü ����, ���� : �ΰ��� ������ �����ϴ� ����ü �����
struct Point
{
    public int x; // public Ű���带 �����Ͽ� �ܺο��� int x ������ ��� ���� �ϵ��� ����
    public int y;
}


public class StructDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ����ü ������ ���� ����: Point ����ü ������ ���� 
        Point p;

        //[3] x, y ������ ���� ����(����, �Ҵ�) �ʱ�ȭ 
        p.x = 100;
        p.y = 200;

        //[4] ��� 

        Debug.Log($"x:{p.x},y:{p.y}");

        
    }
}

/*
Variable(����) : �����͸� �����ϴ� �׸�
Array(�迭) : �ϳ��� �̸����� ���� ������ �����͸� ������ ���� �׸�, ����, ������ Ȯ��

Struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, 
�Ǵ� �Լ����� ��� �����ϴ� �׸�(������ ����),������ Ȯ��
:����� ���� ������ ����

//����ü ����
struct(����ü �̸�)
{
    // ���� �ٸ� ������ �����͵� 
    // �Լ���
}








 */
