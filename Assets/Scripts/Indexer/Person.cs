using UnityEngine;
namespace Indexer
{
    public class Person
    {
        //필드
        private string name;

        //인덱서 : 인덱스 번호와 상관없이 name 필드값을 읽고 쓰는것
        public string this[int index]
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
    }
}