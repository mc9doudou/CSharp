using UnityEngine;

namespace Constructor
{


    public class ConsturctorMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //student 클래스의 인스턴스 생성 - 생성자 호출
            Student student = new Student();

        }
    }
}