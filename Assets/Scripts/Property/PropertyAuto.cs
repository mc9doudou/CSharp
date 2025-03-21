using UnityEngine;

namespace Property
{


    public class PropertyAuto : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck 인스턴스 생성
            Truck car1 = new Truck();
            car1.Name = "제네시스";
            Debug.Log(car1.Name);

            Truck car2 = new Truck();
            car2.Name = "아반테";
            car2.Color = "Red";
            Debug.Log($"차 :{car2.Name}, 색: {car2.Color}");

        }
    }
}