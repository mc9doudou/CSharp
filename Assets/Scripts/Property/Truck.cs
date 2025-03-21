using UnityEngine;
namespace Property
{
    //자동으로 구현되는 속성 사용하기

    public class Truck
    {
        //이름, 색상을 속성 생성
        //[1] 필드와 속성을 함께 사용하는 전체 속성

        private string name;

        public string Name
        {
            get { return name; }    //외부에서 접근해서 사용
            set { name = value; }   //외부에서 전달되는 값을 받아 값 저장 
        }

        //[2]자동으로 수현되는 속성 - 필드가 없음 
        public string Color { get; set; }

        //[3]자동 속성 선언과 동시에 초기화 가능 
        public int Number { get; set; } = 1234;

    }
}
