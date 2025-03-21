using System.Xml.Serialization;
using UnityEngine;
namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        //집에 가기: 직진 -> 우회전 -> 직진 -> 좌회전 

        //대리자 선언 -반환값도 없고 매개변수 없다
        delegate void GoHome();
        //delegate 변수 선언하고 메서드 등록
        GoHome go;

        //Action 형식을 통해 대리자 객체 생성
        //Action, Func
        System.Action driver;

        //대리자 선언
        delegate void Say();
        Say say3;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직접 운전: 직진 -> 우회전 -> 직진 -> 좌회전 
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("==============");

            //대리자 변수에 메서드 등록
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward); //메서드 등록
            go -= new GoHome(CarDriver.GoForward); //메서드 취소
            go();

            //대리자 변수선언 및 메서드 등록
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();

            Debug.Log("==============");
            //메서드 등록 없이 호출 : say3 = null
            /*if (say3 != null)
            {
                
                say3.Invoke();
            }*/
            say3?.Invoke();

            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); };
            driver?.Invoke();


        }
        void Hello() => Debug.Log("Hello");

        void Hi()
        {
            Debug.Log("Hi");
        }


    }
}