using UnityEngine;
namespace Override
{


    public class MathedVirtual : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Animal클래스의 인스턴스 생성
            Animal animal = new Animal();
            animal.Eat();

            //Dog클래스의 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();

            //부모클래스(Animal)의 변수에 자식 클래스(Dog)의 인스턴스 생성 
            Animal dog2 = new Dog();
            dog2.Eat();




        }
    }
}