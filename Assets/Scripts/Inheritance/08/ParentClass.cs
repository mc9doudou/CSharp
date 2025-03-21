using System.Diagnostics;
using UnityEngine;
namespace Inheritance08
{
    //추상 클래스

    public abstract class ParentClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        

    }

    //자식 클래스: 추상 클래스(ParentClass)를 상속 받는다
    public class ChildClass: ParentClass
    {
        public string Name { get; set; }


    }

}