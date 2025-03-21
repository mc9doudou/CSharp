using UnityEngine;
namespace Inheritance
{


    public class BassSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //subClass 인스턴스 생성
            SubClass sub = new SubClass();
            sub.Do();   //Base클래스에 있는 정의된 (공개된public, protected)메서드 사용 가능  
                

        }
    }
}
