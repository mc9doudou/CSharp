using UnityEngine;
using UnityEngine.Rendering;

//�ζ� ��ȣ ������ 
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        System.Random rand = new System.Random();

        //������ �迭 ���� �� ��Ҽ� ����
        int[] numbers = new int[6];

        //
        int number = 0; // �������� �����ϴ� ����
        bool flag = false;//�ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i<6; i++)
        {
            //1~46�� �������� ����
            number = rand.Next(1, 46);

            //�ߺ� üũ - number�� ���� ���� ��ȣ�� ���ؼ� �˻�
            flag = false;
            if (i > 0)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }

            if(flag == false)//�ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            } 
            else   //�ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--;
            }
        }
        for (int i =0;i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }




        /*int[] numbers = new int[45];
        for (int i = 0; i < 45; i++) 
        {
            numbers[i] = i + 1;
        }

        System.Random random = new System.Random();
        
        for (int i = 44; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
        }
    
        for(int i = 0; i < 6; i++)
        {
            Debug.Log($"{numbers[i]}");
        }*/







    }



    
}
/*
[Q]
�ζ� ��ȣ ������ ����� 

[1] 6�� ��ȣ 
[2] 1 ~ 45�� ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ� 
 
//[1] [2]
 
 [output] - ���ǿ� �´� ��ȣ 6�� ���
 
 
 
 */