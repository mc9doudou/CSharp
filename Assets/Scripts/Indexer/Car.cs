using System.Collections;
using UnityEngine;

namespace Indexer
{


    public class Car 
    {
        //[1] 배열 형식의 필드
        private string[] names;
        
        //[2] 생성자 
        public Car(int length)
        {
            //매개변수로 넘어온 길이만큼 필드 배열 생성
            names = new string[length];
        }

        //속성: names의 길이를 반환하는 속성 - 읽기 전용
        public int Length
        {
            get { return names.Length; }

        }

        //[3] 인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        //[4] 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }

    
    }
}
