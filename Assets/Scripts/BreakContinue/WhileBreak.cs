using UnityEngine;

//"1푸터 10까지의 정수의 합을 구하는 프로그램 구현"
//구한 합이 22이상이되면 더이상 합을 구하지 않음
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int n = 10;
        int sum = 0;
        int goal = 22;

        while (i <= n)
        {
            sum += i;
            i++;

            if (sum >= goal)
            {
                break;
            }
        }
        Debug.Log($"1부터 {n}까지의 합: {sum}");
        
    }
}
