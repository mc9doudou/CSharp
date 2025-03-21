using UnityEngine;
namespace Indexer
{


    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 인스턴스 생성
            Car car = new Car(3);
            car[0] = "제네시스";
            car[1] = "그랜져";
            car[2] = "아반테";

            //인덱서 사용
            /*for (int i = 0; i < car.Length; i++)
            {
                Debug.Log(car[i]);
            }*/

            foreach(var c in car)
            {
                Debug.Log(c);
            }

        }
    }
}