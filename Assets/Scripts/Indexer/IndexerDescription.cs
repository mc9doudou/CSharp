using UnityEngine;
namespace indexer
{


    public class IndexerDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Catalog ca = new Catalog();
            Debug.Log(ca[0]); //인스턴스이름[인덱스] 형태로 사용


        }
    }
}
/*
Indexer(인덱서?) 
: 클래스의 인스턴스(객체)를 배열처럼(배열 아님, 배열 형식임) []를 사용할수 있도록 해주는 구조체
: 인스턴스이름[0], 인스턴스이름[1]
: 클래스의 필드(배열, 컬랙션)의 값을 인덱서로 호출해서 사용(읽기 쓰기)이 가능

인덱서 형식 
Class Car 
Car cars = new Car(3);
cars[0] = "a"
cars[1] = "b"
cars[2] = "c"

*/