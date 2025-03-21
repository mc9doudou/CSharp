using UnityEngine;
namespace Inheritance06
{
    //부모 클래스

    public class Parent
    {
        public string Word { get; set; }

        //생성자
        public Parent(string word)
        {
            this.Word = word;
        }
    }
}