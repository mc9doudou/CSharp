using UnityEngine;

//while���� �̿��ؼ� 1���� n(100)������ ������ ���� ���ϴ� ���α׷� ���� 
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 100;
        int sum = 0;

        /*do
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
            i++;
        } while (i <= n);*/

        do
        {
            if (i % 2 != 1)
            {
                sum = sum + i;
            }
            i++;
        } while (i<=n);



        Debug.Log($"1���� {n}������ ¦������: {sum}");


        
    }
}
