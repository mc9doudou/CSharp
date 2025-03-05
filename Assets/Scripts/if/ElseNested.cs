using UnityEngine;

//else 중첩문
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';
        //[1] input이 'y'이면 YES를 출력
        //[2] input이 'n'이면 NO를 출력
        //[3] input이 그외 이면 CANCEL 출력

        if (input == 'y')
        {
            Debug.Log("YES");
        }
        else
        {
            if (input == 'n')

            {
                Debug.Log("NO");
            }
            else
            {
                Debug.Log("CANCEL");
            }
        }

        


    }
}
