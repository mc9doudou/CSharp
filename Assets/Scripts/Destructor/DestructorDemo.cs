using UnityEngine;

namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 인스턴스(하얀, 파란, 빨간)를 생성하고 달리기 구현
            Car whiteCar = new Car();
            whiteCar.Run();

            //whiteCar 페차: GC에서 알아서 소멸

            Car blueCar = new Car("파란색");
            blueCar.Run();

            Car redCar = new Car("빨간색");
            redCar.Run();



        }
    }
}

