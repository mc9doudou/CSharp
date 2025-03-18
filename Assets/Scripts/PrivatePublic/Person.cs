using UnityEngine;
namespace PrivatePublic
{   
    //필드의 종류
    public class Person
    {
        //[1]변수 형식의 필드
        private string name = "홍길동";
        //[2]상수 형식의 필드
        private const int AGE = 21;
        //[3]상수 형식의 필드
        private readonly string NickName = "도깨비";
        //[4]배열 형식의 필드
        private string[] address = {"수원", "서울", "인천"};
        //[5]Object 형식의 필드
        private object all = System.DateTime.Now.ToShortTimeString();
        
        //public 메서드
        public void ShowProfile()
        {
            Debug.Log($"이름:{name}, 나이:{AGE}, 별명:{NickName}");
        }



    }
}