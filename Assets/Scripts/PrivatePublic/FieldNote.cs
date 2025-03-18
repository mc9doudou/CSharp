using UnityEngine;
//using PrivatePublic;


namespace PrivatePublic
{

    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person 클래스의 인스턴스(객체) 생성 
            Person person = new Person();
            person.ShowProfile();
            


        }
    }
}