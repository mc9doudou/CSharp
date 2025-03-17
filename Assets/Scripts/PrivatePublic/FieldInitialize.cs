using UnityEngine;


namespace PrivatePublic
{
    public class FieldInitiallize : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Say 클래스의 인스턴스 생성
            Say say = new Say();
            say.Hi();

        }
    }
}
