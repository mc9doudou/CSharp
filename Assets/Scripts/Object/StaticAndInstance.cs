using UnityEngine;

//정적(static, shared) 멤버 와 인스턴스 멤버
//[1]클래스 선언
public class SharedAndInstance
{
    //static 멤버 메서드
    public static void StaticMember() => Debug.Log("[1]Static Member");

    //instace 멤버 메서드
    public void InstanceMenmber() => Debug.Log("[2] Instance Member"); 

}


public class StaticAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SharedAndInstance 클래스 사용
        //[1] 정적 멤버 사용 =>클래스이름.멤버이름 으로 호출
        SharedAndInstance.StaticMember();

        //[2] 인스턴스 멤버 사용 => 개체이름.멤버이름 으로 호출
        SharedAndInstance obj = new SharedAndInstance();
        obj.InstanceMenmber();
            

    }
}
