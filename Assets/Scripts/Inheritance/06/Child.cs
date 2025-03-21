using UnityEngine;
namespace Inheritance06
{
    //자식 클래스
    public class Child : Parent
    {
        //생성자 
        public Child() : this("홍길동")
        {
            
        }
        public Child(string message) :base(message)
        {

        }

        public void SayName()
        {
            Debug.Log(base.Word);   
        }
    }
}