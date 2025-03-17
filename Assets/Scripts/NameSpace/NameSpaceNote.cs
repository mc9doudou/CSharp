using UnityEngine;


using Korea.Suwon;      //Korea.Suwon에 있는 클래스를 가져다 사용하겠다

//별칭을 사용해서 사용하기, Korea Suwon을 Su네임스페이스 별칭을 만들어 사용
using Su = Korea.Suwon;

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]namespace 이름 전체를 지정(붙여서)해서 사용하기
        Korea.Seoul.car se = new Korea.Seoul.car();
        se.Run(); //서울 자동차가 달린다

        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run();

        //[2]namespace 선언부에 using을 선언하여 사용하기 
        Car seoul = new Car();
        seoul.Run();            //수원 자동차가 달립니다 (suwo car 선언)

        //[3]별칭을 지정해서 사용하기
        Su.Car suwon = new Su.Car();
        suwon.Run();

        //truck 호출하기
        Korea.Seoul.Truck truck = new Korea.Seoul.Truck();
        truck.Run();
    }
}
