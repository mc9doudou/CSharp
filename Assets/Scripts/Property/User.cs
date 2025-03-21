using UnityEngine;
namespace Property
{
    //고객 정보를 관리하는 클래스 

    public class User
    {
        //필드
        private int birthYear;      //생년 

        //자동
        public string Name { get; set; }

        //쓰기 전용 속성
        public int BirthYear
        {
            set
            {
                birthYear = value;
            }
        }

        //읽기 전용 속성 - 계산식
        public int Age
        {
            get
            {
                return (System.DateTime.Now.Year - birthYear);
            }
        }
    }
}