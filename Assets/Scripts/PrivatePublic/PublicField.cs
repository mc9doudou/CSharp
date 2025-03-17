using UnityEngine;

namespace PrivatePublic
{ 
    public class PublicField : MonoBehaviour
    {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Categori 클래스의 인스턴스 생성
            Categori book = new Categori();

            //(다른 클래스의)필드에 데이터 저장 - 개체이름.맴버이름
            book.CategoriName = "책";

            //(다른 클래스의)필드 사용
            Debug.Log(book.CategoriName);



        }
    }
}