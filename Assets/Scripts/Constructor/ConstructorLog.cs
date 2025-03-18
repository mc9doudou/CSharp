using UnityEngine;
namespace Constructor
{

    public class ConstructorLog
    {
        //기본 생성자
        public ConstructorLog()
        {
            Debug.Log("기본 생성자 호출");
        }

        //string 매개변수가 있는 생성자 선언
        public ConstructorLog(string message)
        {
            Debug.Log($"오버로드 된 생성자 실행: {message}");
            
        }

    }
}