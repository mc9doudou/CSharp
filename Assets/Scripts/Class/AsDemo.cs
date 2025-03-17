using UnityEngine;

// as 연산자 : ~ 형식 변환하기, ~ 형식으로 변환이 가능하면 변환, 변환이 불가능하면 null을 반환한다.
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "반갑습니다";
        string r1 = s as string;
        

        Debug.Log($"[1]{r1}");

        object i = 1234;
        string r2 = i as string;
        if (r2 == null)
        {
            Debug.Log($"[2]null 입니다");
        }

        object i2 = 5678;
        if (i2 is string)
        {
            string r3 = i2 as string;
            Debug.Log($"[3]{r3}");
        }
        else
        {
            Debug.Log("[3] 변환 불가");
        }
            
        
    }
}
