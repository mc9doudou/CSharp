using UnityEngine;

// Literal (값) : 
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] 변수 만들기
        int num;    //정수형 변수    num = 1234;
        double su;  //실수형 변수    su = 3.14159;
        bool flag;  //부울형 변수    true혹은 false만가능 
        string str; //문자열 변수    str = "Hello!";
        char c;     //문자형 변수    c = 'a';

        sbyte iSbyte  	//8비트 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 	//16비트 부호가 있는 정수형 변수 선언 및 초기화
        int iInt32  	//32비트 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 	 //64비트 부호가 있는 정수형 변수 선언 및 초기화

        byte iByte  	//8비트 부호가 없는 정수형 변수 선언 및 초기화        0-255
        ushort iUInt16 	//16비트 부호가 없는 정수형 변수 선언 및 초기화       0-65535 
        uint iUInt32  	//32비트 부호가 없는 정수형 변수 선언 및 초기화       0-4,294,967,295
        ulong iUInt64 	 //64비트 부호가 없는 정수형 변수 선언 및 초기화      0-18,446,744,073,709,551,615

        Debug.Log("Message: "+ message);  //[1] "Message: "+ message 문자열 더하기 연산
        Debug.Log($"Message: {message}"); //[2] $"Message: {message}"문자열 보관법으로 출력


        Var : 암시적으로 형식화된 로컬 변수
        var 선언시 데이터 초기화를 반드시 한다  (만능 키)
        
        gettype: 변수의 타입 읽어오기
        string strNumber = "1234";

        int number1 = System.Convert.ToInt32(strNumber);
        Debug.Log($"{number1}-{number1.GetType()}");

        int number2 = int.Parse(strNumber);
        Debug.Log($"{number2}-{number2.GetType()}");

        int number3 = System.Int32.Parse(strNumber);
        Debug.Log($"{number3}-{number3.GetType()}");

         //자리 바꾸기
        temp = i;   //임시변수 (temp) 에 i 값 저장 
        i = j;      //i 변수에 j 값 저장
        j = temp;   //j 변수에 임시변수에 저장되었던 i값을 저장

        int num =10;
        ++num;
        num--;

        //Relational Operator(관계형 연산자, 비교 연산자) :
        < (작음), <=(작거나 같음),  > (큼), >=(크거나 같음), ==(같음), !=(다름) 
        결과 : true(참) / false(거짓) 

        int x=5;
        int y=9;
        Debug.Log(x<y);  => true
       
        NotLogical (부정 연산자, Not) : ! 참이면 거짓이고, 거짓이면 참으로 변환
        OrOperator(Or연산자): || 하나라도 참이면 참 
        andoperator(And연산자 ): And (&&) 둘다 참일때만 참
        결과 :true , false 

        if문 - 조건문 
        조건식이 참일때만 실행문이 실행됩니다.
        조건식이 거짓이면 실행문을 실행하지 않습니다.

        //만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라 
        if(조건식)
        {
        //실행문1
        //실행문2
        //실행문3
        }

        else 문 
        만약 조건식이 참이면 실행문1을 실행하고 실행문2는 실행하지 않는다.
        만약 조건식이 참거짓이면 실행문1을 실행하지 않고 실행문2를 실행한다.

        if(조건식)
        {

        }
        else 
        {
         
        }
 
        //for sum
        1 + 2 + 3... + n-1 + n
        int n = (20)
        int sum = 0;

        for(int i = 1; i < n+1 ; i++ )
        {
            sum = sum + i;
        }

        Debug.Log($"합은 {sum} 입니다");

        
        int number2 = 28;

        if (number2 % 3 == 0)
        {
            Debug.Log($"{number2}는 3의 배수");
        }
        else if (number2 % 5 ==0)
        {
            Debug.Log($"{number2}는 5의 배수");
        }
        else if (number2 % 7 == 0)
        {
            Debug.Log($"{number2}는 7의 배수");
        }
        else 
        {
            Debug.Log($"{number2}는 3,5,7의 배수가 아닌 수");
        }





        */
    }
}
