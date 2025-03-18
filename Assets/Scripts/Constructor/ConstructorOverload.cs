using UnityEngine;

namespace Constructor
{
    public class ConstructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ConstructorLog 클래스 인스턴스 생성
            ConstructorLog log1 = new ConstructorLog();
            ConstructorLog log2 = new ConstructorLog("홍길동");
            ConstructorLog log3 = new ConstructorLog("이길동");
            ConstructorLog log4 = new ConstructorLog("길동");


        }
    }
}

