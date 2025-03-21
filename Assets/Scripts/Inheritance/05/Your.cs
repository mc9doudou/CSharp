using UnityEngine;
namespace Inheritance05
{
    //자식 클래스

    public class Your : Car
    {
        //생성자
        public Your() : this("남의 자동차")
        {

        }
        public Your(string _name) : base(_name)
        {

        }


    }
}