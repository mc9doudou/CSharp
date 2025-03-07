using UnityEngine;
using UnityEngine.Rendering;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ũ�Ⱑ 3�� ������ �迭 �����ϰ� �ʱ�ȭ
        int[] numbers = { 1, 2, 3 };
        //numbers [0] ->1, numbers [1] ->2, numbers [2] ->3

        //�迭�� index�� �����ϴ� ����, �׻� 0���� �ʱ�ȭ, �ε����� ���� 0~(n-1)
        int index = 0;

        Debug.Log(numbers[index++]);// => numbers[0] => 1 , index: 1
        Debug.Log(numbers[index++]);// => numbers[1] => 2 , index: 2
        Debug.Log(numbers[index++]);// => numbers[2] => 3 , index: 3

        Debug.Log(numbers[--index]);// => numbers[2] => 3 , index: 2
        Debug.Log(numbers[--index]);// => numbers[1] => 2 , index: 1
        Debug.Log(numbers[--index]);// => numbers[0] => 1 , index: 0



    }
}
//Index(����, ���) : �� ��°�� ��, [ ] �ȿ� ���� ����, ��

