using UnityEngine;
namespace Property
{
    public class Student
    {
        //필드
        private string name;
        private string address;

        //속성
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
        public int Number { get; set; } = 1;

        //address 값을 읽고 쓰는 메서드
        public void SetAddress(string value)
        {
            address = value;
        }
        public string GetAddress()
        {
            return address;
        }


    }
}