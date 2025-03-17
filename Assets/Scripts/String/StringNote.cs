using UnityEngine;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 변수 str 선언하고 빈값으로 초기화
        string str = "";
        str = System.String.Empty;  // 빈값으로 저장
        str = " Abc Def Fed Cba ";  // 앞뒤에 공백 하나씩 주어서 값 저장

        Debug.Log(str);
        Debug.Log(str.Length);      //문자열 길이 구하기
        Debug.Log(str[5]);          //'D'문자 출력
        Debug.Log(str.ToUpper());   //대문자로 출력
        Debug.Log(str.ToLower());   //소문자로 출력

        //공백 제거 기능
        Debug.Log(str.Trim());      //앞뒤 양쪽 공백 제거
        Debug.Log(str.TrimStart()); //문자열 앞부분 공백 제거
        Debug.Log(str.TrimEnd());   //문자열 뒷부분 공백 제거

        //검색
        Debug.Log(str.IndexOf('e'));        //'e' 가 위치한 인덱스 가져오기 
        Debug.Log(str.Substring(5,3));      //5번 index부터 3글자 가져오기 
        Debug.Log(str.Substring(5));        //5번 인덱스부터 끝까지 가져오기
        Debug.Log(str.Remove(5,3));         //5번 긴덱스부터 3글자 삭제

        //비교
        Debug.Log(str[1] == str[15]);       //false
        Debug.Log("ABC".Equals("Abc"));     //false
        Debug.Log(System.String.Compare("BAC","Bac")); //compare => 0(같음), 1(다름, >), -1(다름, <)

        //연결
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        Debug.Log(System.String.Format("{0}{1}",hi1,hi2));

        //format
        Debug.Log(System.String.Format("{0:C}",1000)); //C : 통화(원화)
        Debug.Log(System.String.Format("{0:#,###}",1000000)); //#,### 세자리 콤마

        //분리하기 - 문자열 전체 공백 제거 
        string[] strArray = str.Trim().Split(' ');
        string strAll = " ";
        foreach(var s in strArray)
        {
            //Debug.Log(s);
            strAll = strAll + s;

        }
        Debug.Log(strAll);
    }
}
