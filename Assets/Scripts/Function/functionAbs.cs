using UnityEngine;
// abs(절대값)을 구하는 함수 만들기
//
public class functionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //-21의 절대값을 구하고 
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number);

        Debug.Log($"{number}의 절대값은 {abs}");
    }

    //매개변수로 들어온 정수의 절대값을 반환하는 함수
    int Abs(int num)
    {
       /* if (num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        }
*/
        return (num < 0) ? -num : num;
    }


}
