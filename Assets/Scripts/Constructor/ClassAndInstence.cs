using UnityEngine;

namespace Constructor
{
    public class ClassAndInstence : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스 생성
            Dog happy = new Dog("해피");
            Debug.Log(happy.Cry());

            //Dog 클래스의 다른 인스턴스 생성
            Dog worry = new Dog("워리");
            Debug.Log(worry.Cry());
        }
    }
}

