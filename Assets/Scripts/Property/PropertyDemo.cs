using Constructor;
using UnityEngine;
namespace Property
{


    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            

            // public 속성이용 횐색 자동차
           

            // 읽기전용 
            Car car3 = new Car();
            //car3.Maker = "대우자동차";
            Debug.Log(car3.Maker);

            // 자동속성, 축약형
            Car myCar = new Car();
            myCar.Name = "봄봄";
            Debug.Log(myCar.Name);
        }
    }
}