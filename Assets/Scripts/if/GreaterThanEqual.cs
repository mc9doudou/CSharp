using UnityEngine;

//GreaterThanEqual 두수를 입력 받아 그중에서 큰수를 출력
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first와 second를 비교해서 큰수를 출력
        // 만약 first가 second이상이면 first값을 출력 아니면 second값을 출력

        if (first>=second)
        {
            Debug.Log($"큰값은 {first}");
        }
        else
        {
            Debug.Log($"큰값은 {second}");
        }
        
    }
}
