using UnityEngine;
namespace method
{

    public class RectangleClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Rectangle 클래스의 인스턴스 생성
            Rectangle rect = new Rectangle();

            Debug.Log(rect.GetName());

        }
    }
}
/*
[1] 메서드 구성 - 문법
public(private) static(있으면 벙벅 메서드 없으면 인서드 메서드) void(반환 타입 없다, int, string) 메서드이름(매개변수...)
{
    //메서드의 실행문 
}

[2] 메서드 이름 - 스타일 
동사 + 이름 : 
()를 가져온다 => GetName(), GetHP()
()를 저장한다 => SetName("홍길동");


*/
