using UnityEngine;
namespace Inheritance05
{

    // 자식 클래스
    public class My : Car
    {
        public My() : this("나의 자동차") //???
        {

        }
        public My(string _name) : base(_name)
        {
            
        }

    }
}