using UnityEngine;
namespace Inheritance10
{
    //원을 관리하는 클래스

    public class Circle : Shape
    {
        //필드
        private int r;      //반지름

        //생성자
        public Circle(int _r)
        {
            this.r = _r;
        }

        //부모클래스의 추상메서드(GetArea())를 구현
        public override double GetArea()
        {
            return r * r * 3.14;
        }

    }
}