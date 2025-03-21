using UnityEngine;
namespace indexer
{
    public class Catalog
    {
        //문자열(string) 인덱서
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}는 짝수": $"{index}는 홀수";
            }
        }


    }
}