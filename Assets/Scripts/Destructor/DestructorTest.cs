using UnityEngine;
namespace Constructor
{
    public class DestructorTest
    {
        //생성자
        public DestructorTest()
        {
            Debug.Log("[1] 생성");
        }
        public void Run()
        {
            Debug.Log("[2] 실행");
        }

        //소멸자
        ~DestructorTest()
        {
            Debug.Log("[3] 소멸");
        }
    }

}