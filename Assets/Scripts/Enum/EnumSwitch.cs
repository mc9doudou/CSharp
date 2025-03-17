using UnityEngine;

//열거형은 Switch문과 함께 많이 사용되어진다
//한글 동물 이름 출력
enum Animall
{
    Chicken,
    Dog,
    Penguin

}


public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 설정 및 초기화
        Animall ani = Animall.Chicken;
        PrintAnimal(ani);


    }


    //매개변수 열거형 변수를 받아 한글 이름 출력하기
    void PrintAnimal(Animall animal)
    {
        switch (animal)
        {
            case Animall.Chicken:
                Debug.Log("닭");
                break;
            case Animall.Dog:
                Debug.Log("개");
                break;
            case Animall.Penguin:
                Debug.Log("팽귄");
                break;
        }
    } 


}
