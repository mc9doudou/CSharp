using UnityEngine;
namespace Constructor
{


    public class Person
    {
        //[1] 필드
        private string name;

        //[2] 생성자 - 기번 생성자
        public Person()
        {
            name = "홍길동";
        }
        
        //[3] 생성자 - 매개변수로 이름 입력받는다
        public Person(string _name)
        {
            name = _name;
        }

        //[4] 메서드 - private한 이름을 public한 메서드로 외부에서 사용 가능하도록 한다
        public string GetName()
        {
            return name;
        }

    }
}