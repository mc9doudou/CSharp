using UnityEngine;
namespace Delegate
{
    public class DelegateDemo : MonoBehaviour
    {
        //[1]delegate생성 -double형 반환 매개변수 int
        //delegate

        delegate double GetCircleArea(int r);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2] delegate 변수 선언하고 메서드 등록
            GetCircleArea area = GetArea;

            //[3]delegate 사용: 변수를 통해 메서드 호출
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));


        }

        double GetArea(int r)
        {
            return 3.14*r*r;
        }

    }
}
