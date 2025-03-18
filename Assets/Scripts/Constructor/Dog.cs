using UnityEngine;

namespace Constructor
{
    public class Dog
    {
        //[1] 필드
        private string name;

        //[2] 생성자 : 필드의 초기값  설정
        //매개변수를 받아서 name 필드 값 설정

        public Dog(string _name)
        {
            name = _name;
        }



        //[3] name 필드를 반환하는 메서드 
        public string Cry()
        {
            return name + "가(이) 멍멍멍";
        }


    }
}